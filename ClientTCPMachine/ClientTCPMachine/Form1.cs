using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientTCPMachine
{
    public partial class Form1 : Form
    {
        int turn = 0;
        bool flag = false;
        PictureBox selection = null;
        List<PictureBox> redColor = new List<PictureBox>();
        List<PictureBox> BlueColor = new List<PictureBox>();
        TcpClient client = new TcpClient();
        IPAddress ipaddress = IPAddress.Parse("127.0.0.1");
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
            try
            {
                if (label1.Text != "Connected")
                {
                    groupBox1.Show();
                    client.Connect(ipaddress, 8001);
                    label1.Text = "Connected";
                    Thread t = new Thread(() => Receive());
                    t.IsBackground = true;
                    t.Start();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Connection failed.....");
            }
        }

        private void Receive()
        {
            try
            {
                var stream = client.GetStream();
                var reader = new StreamReader(stream);
                while (true)
                {
                    var serverMessage = reader.ReadLine();
                    if (serverMessage == "End")
                        break;
                    //lbxmsgs.Items.Add(serverMessage);//show data in listbox-

                }
                label1.Text = "Connection end";
                client.Close();
            }
            catch (Exception eobj)
            {
                MessageBox.Show(eobj.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (label1.Text == "Connected")
                {
                    var stream = client.GetStream();
                    var writer = new StreamWriter(stream);

                    if (comboBox1.SelectedItem.ToString() == "Online")
                    {
                        writer.WriteLine("Online");

                    }
                    else
                    {
                        writer.WriteLine("Away");

                    }
                    //writer.WriteLine(txtmsg.Text);

                    writer.Flush();
                }
            }
            catch (Exception eobj)
            {
                MessageBox.Show(eobj.Message);
            }

        }

        private void selectionCards(object sender, MouseEventArgs e)
        {
            movementAnimation((PictureBox)sender);
        }

        private void selectionBlue(object sender, MouseEventArgs e)
        {
            selectedBox(sender);
        }

        private void selectionRed(object sender, MouseEventArgs e)
        {
            selectedBox(sender);
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Hide();
        }
    }
}
