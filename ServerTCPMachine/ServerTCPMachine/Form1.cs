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

namespace ServerTCPMachine
{
    public partial class Form1 : Form
    {
        int turn = 0;
        bool flag = false;
        PictureBox selection = null;
        List<PictureBox> redColor = new List<PictureBox>();
        List<PictureBox> BlueColor = new List<PictureBox>();

        TcpListener listner = new TcpListener(8001);  // using System.Net.Socktes   // using System.Net; is required for EndPoint
        public static StreamWriter sw;
        List<Socket> clients = new List<Socket>();
        public Form1()
        {
            InitializeComponent();
        }
        public void AddingColorinList()
        {
            redColor.Add(red1);
            redColor.Add(red2);
            redColor.Add(red3);
            redColor.Add(red4);
            redColor.Add(red5);
            redColor.Add(red6);
            redColor.Add(red7);
            redColor.Add(red8);
            redColor.Add(red9);
            redColor.Add(red10);
            redColor.Add(red11);
            redColor.Add(red12);



            BlueColor.Add(blue1);
            BlueColor.Add(blue2);
            BlueColor.Add(blue3);
            BlueColor.Add(blue4);
            BlueColor.Add(blue5);
            BlueColor.Add(blue6);
            BlueColor.Add(blue7);
            BlueColor.Add(blue8);
            BlueColor.Add(blue9);
            BlueColor.Add(blue10);
            BlueColor.Add(blue11);
            BlueColor.Add(blue12);

        }
        

        public void selectedBox(object sender)
        {
            try
            {
                selection.BackColor = Color.Black;
            }
            catch (Exception ex)
            {

                //throw;
            }
            PictureBox select = (PictureBox)sender;
            selection = select;
            selection.BackColor = Color.Lime;
        }

        private void button65_Click(object sender, EventArgs e)
        {
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
                while (true)
                {
                    msg = reader.ReadLine();
                    if (msg == "end")
                    {
                        break;
                    }
                    string m = "Status  " + msg + " IP Address  " + ep.ToString();
                    listBox1.Items.Add(m);
                   
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

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        private void selectionBlue(object sender, MouseEventArgs e)
        {
            //selectedBox(sender);
        }

        private void selectionRed(object sender, MouseEventArgs e)
        {
            selectedBox(sender);
        }

        private void selectionCards(object sender, MouseEventArgs e)
        {
            movementAnimation((PictureBox)sender);
        }
        private void movementAnimation(PictureBox card)
        {
            if (selection != null)
            {
                if (true)//verification
                {
                    string color = selection.Name.ToString().Substring(0, 4);
                    Point point = selection.Location;
                    selection.Location = card.Location;
                    int y = point.Y - card.Location.Y;

                    if (true)//verification movment
                    {
                        turn++;
                        selection.BackColor = Color.Black;
                        selection = null;
                        flag = false;
                    }
                    else
                    {
                        flag = true;
                    }
                }
            }
        }
    }
}
