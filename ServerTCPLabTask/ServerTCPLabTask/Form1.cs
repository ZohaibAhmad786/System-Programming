




///<summary>
///This is Working Form Project TCP Server Client Game Based
/// 
/// </summary>



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Net;

namespace ServerTCPLabTask
{
    public partial class Form1 : Form
    {
        public static int lower, upper, num;
        public static int counter = 2;
        TcpListener listner = new TcpListener(8001);  // using System.Net.Socktes   // using System.Net; is required for EndPoint
        public static StreamWriter sw;
        List<Socket> clients = new List<Socket>();
        public static string objtimein, objtimeout;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
             lower = 1;
             upper = 90;
            var numgues = new Random();
             num = numgues.Next(lower, upper);
            label4.Text = "" + lower;
            label5.Text = "" + upper;
            label6.Text = "" + num;
            
            if (label1.Text != "Server is on")
            {
                label1.Text = "Server is on";
                listner.Start();
                Thread th = new Thread(() =>
                {

                    Acceptsockets();


                }); // using System.Threading
                th.IsBackground = true;
                th.Start();
            }

        }

        private void Acceptsockets()
        {
            while (true)
            {
                
                    var socket = listner.AcceptSocket();
                    clients.Add(socket);
                    
                    Thread listen = new Thread(() => ListenClients(socket));
                    listen.IsBackground = true;
                    listen.Start();
                
            }

        }

        private void ListenClients(Socket clientsocket)
        {

            try
            {
                var stream = new NetworkStream(clientsocket);
                var reader = new StreamReader(stream);  // System.IO
                var writer = new StreamWriter(stream);
                writer.AutoFlush = true;
                string msg;
                EndPoint ep = clientsocket.RemoteEndPoint;
                writer.WriteLine(" " + lower + " --- " + upper);
                int yes = 0, no = 0;
                while (true)
                {
                    
                    var client = reader.ReadLine();
                    if (client == "Score")
                    {
                        writer.WriteLine("Correct "+yes+" Wrong "+no);
                    }else if (client.Contains("-"))
                    {
                        lower = int.Parse(client.Split('-')[0]);
                        upper = int.Parse(client.Split('-')[1]);
                        
                        var numgues = new Random();
                        num = numgues.Next(lower, upper);
                        label4.Text = "" + lower;
                        label5.Text = "" + upper;
                        label6.Text = "" + num;
                        writer.WriteLine(" " + lower + " --- " + upper);
                    }else if (client=="quit")
                    {
                        writer.WriteLine("end");
                        break;
                    }
                    else
                    {
                        int clientMsg = int.Parse(client);
                        if (clientMsg == num)
                        {
                            yes++;
                            writer.WriteLine("Correct");
                        }
                        else
                        {
                            no++;
                            writer.WriteLine("Wrong");

                        }
                    }
                    
                }

               
                clients.Remove(clientsocket);
                clientsocket.Close();

            }
            catch (Exception eobj)
            {
                if (clientsocket != null)
                {
                    clients.Remove(clientsocket);
                    clientsocket.Close();
                }
            }

        }
    }
}
