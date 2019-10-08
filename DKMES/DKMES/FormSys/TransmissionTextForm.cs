using System;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace DKMES.FormSys
{
    public partial class TransmissionTextForm : Form
    {
        TcpClient ClientSocket = default(TcpClient);
        TcpClient SVClient = new TcpClient();

        public TransmissionTextForm()
        {
            InitializeComponent();
            string name = Dns.GetHostName();
            IPHostEntry hostname = Dns.GetHostByName(name);
            IPAddress[] IP = hostname.AddressList;
            lbIPSV.Text = IP[0].ToString();
        }

        private void ChatBox_MOD(string text)
        {
            //txtChatBox.Focus();
            txtChatBox.AppendText(Environment.NewLine + text);
            txtChatBox.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void Status_MOD(string text)
        {
            tsSVStatus.Text = text;
        }

        private void CLStatus_MOD(string text)
        {
            tsCLStatus.Text = text;
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            Thread StartSV = new Thread(StrartServer);
            if (!StartSV.IsAlive)
            {
                StartSV.Start();
            }
        }

        private void StrartServer()
        {
            try
            {
                Action<string> Delegate_ChatBox = ChatBox_MOD;
                Action<string> Delegate_Status = Status_MOD;
                IPAddress IPSV = IPAddress.Parse(lbIPSV.Text);
                int PortSV = int.Parse(txtPortServer.Text);
                TcpListener SVListener = new TcpListener(IPSV, PortSV);
                SVListener.Start();
                Invoke(Delegate_Status, "Waiting connect");
                ClientSocket = SVListener.AcceptTcpClient();
                Invoke(Delegate_Status, "Ready");
                while (true)
                {
                    try
                    {
                        Invoke(Delegate_ChatBox, RecieveText());
                        Invoke(Delegate_Status, "Recieved");
                        SVListener.Stop();
                    }
                    catch
                    {
                        SVListener.Stop();
                        Invoke(Delegate_Status, "Stopped");
                        SVListener.Start();
                        Invoke(Delegate_Status, "Waiting connect");
                        ClientSocket = SVListener.AcceptTcpClient();
                        Invoke(Delegate_Status, "Ready");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string RecieveText()
        {
            Action<string> Delegate_CLStatus = CLStatus_MOD;
            NetworkStream NetStream = ClientSocket.GetStream();
            byte[] RecByte = new byte[20];
            NetStream.Read(RecByte, 0, 20);
            string DataFromClient = System.Text.Encoding.ASCII.GetString(RecByte);
            DataFromClient = DataFromClient.Substring(0, DataFromClient.IndexOf("$"));
            Invoke(Delegate_CLStatus, "Recieved");
            return DataFromClient;
        }

        private void SendText(string sendtext)
        {
            Action<string> Delegate_CLStatus = CLStatus_MOD;
            sendtext += "$";
            NetworkStream NetStream = SVClient.GetStream();
            byte[] SendByte = System.Text.Encoding.ASCII.GetBytes(sendtext);
            NetStream.Write(SendByte, 0, SendByte.Length);
            NetStream.Flush();
            //txtChatBox.Focus();
            txtChatBox.AppendText(Environment.NewLine
                                    + sendtext.Substring(0, sendtext.IndexOf("$")));
            txtChatBox.SelectionAlignment = HorizontalAlignment.Right;
            Invoke(Delegate_CLStatus, "Sent");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                Action<string> Delegate_CLStatus = CLStatus_MOD;
                IPAddress IPCL = IPAddress.Parse(txtIPCLient.Text);
                int PortCL = int.Parse(txtPortClient.Text);
                if (!SVClient.Connected)
                    SVClient.Connect(IPCL, PortCL);
                Invoke(Delegate_CLStatus, "Ready");
                SendText(txtSend.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtChatBox_TextChanged(object sender, EventArgs e)
        {
            txtChatBox.SelectionStart = txtChatBox.Text.Length;
            txtChatBox.ScrollToCaret();
        }
    }
}
