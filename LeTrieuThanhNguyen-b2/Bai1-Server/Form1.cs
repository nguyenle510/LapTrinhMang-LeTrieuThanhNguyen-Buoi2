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

namespace Bai1_Server
{
    public partial class Form1 : Form
    {
        Socket server;
        Socket client;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {

        }

        private void lsB1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            byte[] data = Encoding.ASCII.GetBytes(txt2.Text);
            client.Send(data);
            lsB1.Items.Add("Server: " + txt2.Text);
            txt2.Text = "";
            data = new byte[1024];
            client.Receive(data);
            lsB1.Items.Add("Client: " + Encoding.ASCII.GetString(data));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 12345);
            server.Bind(ipep);
            server.Listen(4);
            client = server.Accept();
        }
    }
}
