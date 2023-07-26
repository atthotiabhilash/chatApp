using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using serverdll;

namespace server
{
    public partial class Server : Form
    {
        private TcpListener server;
        private TcpClient client;
        private Thread listenerThread;
        private NetworkStream stream;
        
        public Server()
        {
            InitializeComponent();
            client = new TcpClient();
        }

        private void MessageForm_Load(object sender, EventArgs e)
        {

        }
        private void StartListening()
        {
            Int32 portNumber = 8888;
            string IpAddress = "127.0.0.1";
            //"127.0.0.1"
            IPAddress address = IPAddress.Parse(IpAddress);
            server = new TcpListener(address, portNumber);
            try
            {
                server.Start();

                while (true)
                {
                    client = server.AcceptTcpClient();
                    NetworkStream stream = client.GetStream();
                    byte[] data = new byte[1024];
                    int bytesRead = stream.Read(data, 0, data.Length);
                    string msg = Encoding.ASCII.GetString(data, 0, bytesRead);
                    this.Invoke((MethodInvoker)delegate
                    {
                        outputBox.Text += "Client: " + msg + "\r\n";
                    });
                    string message1 = "Server: Received the message";
                    byte[] data1 = Encoding.ASCII.GetBytes(message1);
                    stream.Write(data1, 0, data1.Length);
                }
            }
            catch (Exception ex)
            {  
                outputBox.Text= ex.ToString();

            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            listenerThread = new Thread(StartListening);
            listenerThread.Start();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            //listenerThread.Abort();
        }
        private void outputBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void clear_Click(object sender, EventArgs e)
        {
            outputBox.Text = string.Empty;
        }
    }
}
