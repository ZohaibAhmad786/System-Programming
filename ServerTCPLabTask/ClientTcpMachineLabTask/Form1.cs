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
using System.Net;
using System.IO;
using System.Threading;

namespace ClientTcpMachineLabTask
{
    public partial class Form1 : Form
    {
        TcpClient client = new TcpClient();
        IPAddress ipaddress = IPAddress.Parse("192.168.102.1");
        public static object data;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            try
            {
                if (label5.Text != "Connected")
                {
                    client.Connect(ipaddress, 8001);
                    label5.Text = "Connected";
                    Thread t = new Thread(() => Receive1());
                    t.IsBackground = true;
                    t.Start();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Connection failed.....");
            }
        }
        void Receive1()
        {
            try
            {
                var stream = client.GetStream();
                var reader = new StreamReader(stream);
                StreamWriter writer = new StreamWriter(stream);
                var serverMessage = reader.ReadLine();
                label2.Text = serverMessage;
               
                //label1.Text = "Connection end";
                //client.Close();
            }
            catch (Exception eobj)
            {
                MessageBox.Show(eobj.Message);
            }

        }
        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            try
            {
                if (label5.Text == "Connected")
                {
                    var stream = client.GetStream();
                    StreamWriter writer = new StreamWriter(stream);
                    writer.WriteLine(txtSearch.Text);
                    writer.Flush();
                    var reader = new StreamReader(stream);
                    label3.Text = reader.ReadLine();
                    
                }
            }
            catch (Exception eobj)
            {
                MessageBox.Show(eobj.Message);
            }

            

        }

        
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //data = txtSearch.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (label5.Text == "Connected")
                {
                    var stream = client.GetStream();
                    StreamWriter writer = new StreamWriter(stream);
                    writer.WriteLine(txtQuite.Text);
                    writer.Flush();
                    var reader = new StreamReader(stream);
                    if (reader.ReadLine() == "end")
                    {
                        Application.Exit();
                    }

                }
            }
            catch (Exception eobj)
            {
                MessageBox.Show(eobj.Message);
            }
        }

        private void btnSocre_Click(object sender, EventArgs e)
        {
            try
            {
                if (label5.Text == "Connected")
                {
                    var stream = client.GetStream();
                    StreamWriter writer = new StreamWriter(stream);
                    writer.WriteLine(txtScore.Text);
                    writer.Flush();
                    var reader = new StreamReader(stream);
                    label4.Text = reader.ReadLine();

                }
            }
            catch (Exception eobj)
            {
                MessageBox.Show(eobj.Message);
            }
        }

        private void btnRange_Click(object sender, EventArgs e)
        {
            try
            {
                if (label5.Text == "Connected")
                {
                    var stream = client.GetStream();
                    StreamWriter writer = new StreamWriter(stream);
                    writer.WriteLine(txtrang.Text);
                    writer.Flush();
                    var reader = new StreamReader(stream);
                    label2.Text = reader.ReadLine();

                }
            }
            catch (Exception eobj)
            {
                MessageBox.Show(eobj.Message);
            }
        }
    }
}
