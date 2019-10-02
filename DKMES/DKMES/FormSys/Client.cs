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
using System.IO;

namespace DKMES.FormSys
{
    public partial class ClientForm : Form
    {
        TcpClient tcpclnt = new TcpClient();

        //Declare and Initialize the IP Adress
        IPAddress ipAd = IPAddress.Parse("172.26.202.162");

        //Declare and Initilize the Port Number;
        int PortNumber = 8888;

        public ClientForm()
        {
            InitializeComponent();

        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            //Console.WriteLine("Connecting.....");
            try
            {
                tcpclnt.Connect(ipAd, PortNumber);
                txtStatus.Text += Environment.NewLine + "Connected";
                txtStatus.Text += Environment.NewLine + "Enter the string to be transmitted";
            }
            catch { }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            String str = txtEnviar.Text + "$";
            Stream stm = tcpclnt.GetStream();

            ASCIIEncoding asen = new ASCIIEncoding();
            byte[] ba = asen.GetBytes(str);

            txtStatus.Text += Environment.NewLine + "Transmitting...";
            //Console.WriteLine("Transmitting.....");

            stm.Write(ba, 0, ba.Length);

            byte[] bb = new byte[100];
            int k = stm.Read(bb, 0, 100);

            string Response = Encoding.ASCII.GetString(bb);

            txtStatus.Text += Environment.NewLine + "Response from server: " + Response;

        }
    }
}