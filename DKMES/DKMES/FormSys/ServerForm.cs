using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;


using System.Threading;

namespace DKMES.FormSys
{
    public partial class ServerForm : Form
    {

        //Declare and Initialize the IP Adress
        static IPAddress ipAd = IPAddress.Parse("172.26.202.162");

        //Declare and Initilize the Port Number;
        static int PortNumber = 8888;

        /* Initializes the Listener */
        TcpListener ServerListener = new TcpListener(ipAd, PortNumber);
        TcpClient clientSocket = default(TcpClient);

        public ServerForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread ThreadingServer = new Thread(StartServer);
            ThreadingServer.Start();
        }

        private void THREAD_MOD(string teste)
        {
            txtStatus.Text += Environment.NewLine + teste;
        }

        private void THREAD_MOD2(string teste)
        {
            textBox1.Text += Environment.NewLine + teste;
        }

        private void StartServer()
        {
            Action<string> DelegateTeste_ModifyText = THREAD_MOD;
            Action<string> DelegateTeste_ModifyText2 = THREAD_MOD2;

            ServerListener.Start();
            Invoke(DelegateTeste_ModifyText, "Server waiting connections!");
            clientSocket = ServerListener.AcceptTcpClient();
            Invoke(DelegateTeste_ModifyText, "Server ready!");

            while (true)
            {
                try
                {

                    NetworkStream networkStream = clientSocket.GetStream();
                    byte[] bytesFrom = new byte[20];
                    networkStream.Read(bytesFrom, 0, 20);
                    string dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);
                    dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));
                    string serverResponse = "Received!";
                    Byte[] sendBytes = Encoding.ASCII.GetBytes(serverResponse);
                    networkStream.Write(sendBytes, 0, sendBytes.Length);
                    networkStream.Flush();
                    Invoke(DelegateTeste_ModifyText2, dataFromClient);
                }
                catch
                {
                    ServerListener.Stop();
                    ServerListener.Start();
                    Invoke(DelegateTeste_ModifyText, "Server waiting connections!");
                    clientSocket = ServerListener.AcceptTcpClient();
                    Invoke(DelegateTeste_ModifyText, "Server ready!");
                }

            }
        }
    }
}