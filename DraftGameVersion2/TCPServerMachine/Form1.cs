using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPServerMachine
{
    public partial class Form1 : Form
    {
        int turn = 0;
        bool flag = false;
        PictureBox selection = null;
        List<PictureBox> redColor = new List<PictureBox>();
        List<PictureBox> BlueColor = new List<PictureBox>();
        public Form1()
        {
            InitializeComponent();
            AddingColorinList();
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
        private bool moveintoExtra(string color)
        {
            string col = color;
            List<PictureBox> picboxes = color.Contains("red") ? redColor : BlueColor;
            List<Point> position = new List<Point>();
            int sigPosition = col.Contains("red") ? -100 : 100;


            position.Add(new Point(selection.Location.X + 100, selection.Location.Y + sigPosition));
            position.Add(new Point(selection.Location.X - 100, selection.Location.Y + sigPosition));
            if (selection.Tag == "queen")
            {
                position.Add(new Point(selection.Location.X + 100, selection.Location.Y + sigPosition));
                position.Add(new Point(selection.Location.X - 100, selection.Location.Y + sigPosition));
            }
            bool result = false;
            for (int i = 0; i < position.Count; i++)
            {
                if(position[i].X>=50 && position[i].X<=400 && position[i].Y >= 50 && position[i].Y <= 400)
                {
                   if(!ocupied(position[i],BlueColor) && !ocupied(position[i], redColor))
                    {
                        Point pointMid = new Point(pointer(position[i].X, selection.Location.X), pointer(position[i].Y, selection.Location.Y));
                        if (ocupied(pointMid, picboxes))
                        {
                            result = true;
                        }
                    }
                }
            }
            return result;
        }
        private bool ocupied(Point point,List<PictureBox> box)
        {
            for (int i = 0; i < box.Count; i++)
            {
                if (point == box[i].Location)
                {
                    return true;
                }
            }
            return false;
        }
        private void movementAnimation(PictureBox card)
        {
            if (selection != null)
            {
               
                if (/*validation(selection,card,color)*/true)//verification
                {
                    string color = selection.Name.ToString().Substring(0, 4);
                    Point point = selection.Location;
                    selection.Location = card.Location;
                    int y = point.Y - card.Location.Y;

                    if (/*!moveintoExtra(color) | Math.Abs(y)==50*/true)//verification movment
                    {
                        ifQueen(color);
                        turn++;
                        selection.BackColor = Color.Black;
                        selection = null;
                        flag = false;
                    }else
                    {
                        flag = true;
                    }
                }
            }
        }
        private int pointer(int x,int y)
        {
            int res = x + y;
            res = res / 2;
            return Math.Abs(res);

        }
        private bool validation(PictureBox orgion,PictureBox destination,string color)
        {
            Point Orig = orgion.Location;
            Point dest = destination.Location;
            int ans = Orig.Y - dest.Y;
            ans = color == "blue" ? ans : (ans * -1);
            ans = selection.Tag == "queen" ? Math.Abs(ans) : ans;

            if (ans == 50)
            {
                return true;
            }else if (ans == 100)
            {
                Point pointto = new Point(pointer(dest.X, Orig.X), pointer(dest.Y, Orig.Y));
                List<PictureBox> controls = color == "blue" ? BlueColor : redColor;
                for (int i = 0; i < controls.Count; i++)
                {
                    if (controls[i].Location == pointto)
                    {
                        controls[i].Location = new Point(0, 0);
                        controls[i].Visible = false;
                        return true;
                    }
                }
            }
            return false;
        }
        public void ifQueen(string color)
        {
            if(color.Contains("red") && selection.Location.Y == 380)
            {
                selection.BackgroundImage = Properties.Resources.redq;
                selection.Tag = "queen";
            }
            else if (color=="blue" && selection.Location.Y==50)
            {
                selection.BackgroundImage = Properties.Resources.blueq;
                selection.Tag = "queen";
            }
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

        private void SelectionRed(object sender, MouseEventArgs e)
        {
            selectedBox(sender);
        }

        private void SelectionBlue(object sender, MouseEventArgs e)
        {
            //roja
            selectedBox(sender);
        }

        private void SelectionCards(object sender, MouseEventArgs e)
        {
            movementAnimation((PictureBox)sender);
        }
    }
}
