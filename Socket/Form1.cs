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

namespace Socket
{
    public partial class Form1 : Form
    {

        int port = 8000;
        string message = "hello";
        int bytecount;
        NetworkStream stream;
        byte[] sendData;
        TcpClient client;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void connect_Click(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient("192.168.12.107", port);
                stream = client.GetStream();
                MessageBox.Show("Connection Made");
            }

            catch (System.Net.Sockets.SocketException)
            {
                MessageBox.Show("Connect Failed");
            }
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            try
            {
                bytecount = Encoding.ASCII.GetByteCount("Write");
                sendData = new byte[bytecount];
                sendData = Encoding.ASCII.GetBytes("Write");
                stream.Write(sendData, 0, sendData.Length);

                message = textBox_send.Text;
                bytecount = Encoding.ASCII.GetByteCount(message);
                sendData = new byte[bytecount];
                sendData = Encoding.ASCII.GetBytes(message);
                stream.Write(sendData, 0, sendData.Length);
            }

            catch (System.Net.Sockets.SocketException)
            {
                MessageBox.Show("Send Failed");
            }


        }

        private void button_recv_Click(object sender, EventArgs e)
        {
            try
            {

                bytecount = Encoding.ASCII.GetByteCount("Read");
                sendData = new byte[bytecount];
                sendData = Encoding.ASCII.GetBytes("Read");
                stream.Write(sendData, 0, sendData.Length);

                byte[] data = new Byte[1024]; // store the response bytes
                textBox_data_recv.Text = String.Empty;
                int bytes = stream.Read(data, 0, data.Length);
                string responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                textBox_data_recv.Text = responseData;
                Console.WriteLine("Received: {0}", responseData);
            }
            catch(System.Net.Sockets.SocketException)
            {
                MessageBox.Show("Receive Failed");
            }
        }

        private void button_disconnect_Click(object sender, EventArgs e)
        {
            stream.Close();
            client.Close();
        }
    }
}
