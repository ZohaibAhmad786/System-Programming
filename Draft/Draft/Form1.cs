using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Collections;
using System.Threading;


namespace Draft
{
    class GameBoard
    {// constructor
        private Button button;
        private char mark;
        private int location;

        public GameBoard(Button newButton, char newMark, int newLocation)
        {
            button = newButton;
            mark = newMark;
            location = newLocation;
        } // end constructor

        // property SquarePanel; the panel which the square represents
        public Button Button
        {
            get
            {
                return button;
            } // end get
        } // end property SquarePanel

        // property Mark; the mark on the square
        public char Mark
        {
            get
            {
                return mark;
            } // end get
            set
            {
                mark = value;
            } // end set
        } // end property Mark

        // property Location; the square's location on the board
        public int Location
        {
            get
            {
                return location;
            } // end get
        } // end property Location
    }

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             //sets up array spaces for buttons
            buttons[0, 0] = new GameBoard(button1, 'b', 1);
            buttons[0, 1] = new GameBoard(button2, ' ', 2);
            buttons[0, 2] = new GameBoard(button3, 'b', 3);
            buttons[0, 3] = new GameBoard(button4, ' ', 4);
            buttons[0, 4] = new GameBoard(button5, 'b', 5);
            buttons[0, 5] = new GameBoard(button6, ' ', 6);
            buttons[0, 6] = new GameBoard(button7, 'b', 7);
            buttons[0, 7] = new GameBoard(button8, ' ', 8);
            buttons[1, 0] = new GameBoard(button9, ' ', 9);
            buttons[1, 1] = new GameBoard(button10, 'b', 10);
            buttons[1, 2] = new GameBoard(button11, ' ', 11);
            buttons[1, 3] = new GameBoard(button12, 'b', 12);
            buttons[1, 4] = new GameBoard(button13, ' ', 13);
            buttons[1, 5] = new GameBoard(button14, 'b', 14);
            buttons[1, 6] = new GameBoard(button15, ' ', 15);
            buttons[1, 7] = new GameBoard(button16, 'b', 16);
            buttons[2, 0] = new GameBoard(button17, 'b', 17);
            buttons[2, 1] = new GameBoard(button18, ' ', 18);
            buttons[2, 2] = new GameBoard(button19, 'b', 19);
            buttons[2, 3] = new GameBoard(button20, ' ', 20);
            buttons[2, 4] = new GameBoard(button21, 'b', 21);
            buttons[2, 5] = new GameBoard(button22, ' ', 22);
            buttons[2, 6] = new GameBoard(button23, 'b', 23);
            buttons[2, 7] = new GameBoard(button24, ' ', 24);
            buttons[3, 0] = new GameBoard(button25, ' ', 25);
            buttons[3, 1] = new GameBoard(button26, ' ', 26);
            buttons[3, 2] = new GameBoard(button27, ' ', 27);
            buttons[3, 3] = new GameBoard(button28, ' ', 28);
            buttons[3, 4] = new GameBoard(button29, ' ', 29);
            buttons[3, 5] = new GameBoard(button30, ' ', 30);
            buttons[3, 6] = new GameBoard(button31, ' ', 31);
            buttons[3, 7] = new GameBoard(button32, ' ', 32);
            buttons[4, 0] = new GameBoard(button33, ' ', 33);
            buttons[4, 1] = new GameBoard(button34, ' ', 34);
            buttons[4, 2] = new GameBoard(button35, ' ', 35);
            buttons[4, 3] = new GameBoard(button36, ' ', 36);
            buttons[4, 4] = new GameBoard(button37, ' ', 37);
            buttons[4, 5] = new GameBoard(button38, ' ', 38);
            buttons[4, 6] = new GameBoard(button39, ' ', 39);
            buttons[4, 7] = new GameBoard(button40, ' ', 40);
            buttons[5, 0] = new GameBoard(button41, ' ', 41);
            buttons[5, 1] = new GameBoard(button42, 'r', 42);
            buttons[5, 2] = new GameBoard(button43, ' ', 43);
            buttons[5, 3] = new GameBoard(button44, 'r', 44);
            buttons[5, 4] = new GameBoard(button45, ' ', 45);
            buttons[5, 5] = new GameBoard(button46, 'r', 46);
            buttons[5, 6] = new GameBoard(button47, ' ', 47);
            buttons[5, 7] = new GameBoard(button48, 'r', 48);
            buttons[6, 0] = new GameBoard(button49, 'r', 49);
            buttons[6, 1] = new GameBoard(button50, ' ', 50);
            buttons[6, 2] = new GameBoard(button51, 'r', 51);
            buttons[6, 3] = new GameBoard(button52, ' ', 52);
            buttons[6, 4] = new GameBoard(button53, 'r', 53);
            buttons[6, 5] = new GameBoard(button54, ' ', 54);
            buttons[6, 6] = new GameBoard(button55, 'r', 55);
            buttons[6, 7] = new GameBoard(button56, ' ', 56);
            buttons[7, 0] = new GameBoard(button57, ' ', 57);
            buttons[7, 1] = new GameBoard(button58, 'r', 58);
            buttons[7, 2] = new GameBoard(button59, ' ', 59);
            buttons[7, 3] = new GameBoard(button60, 'r', 60);
            buttons[7, 4] = new GameBoard(button61, ' ', 61);
            buttons[7, 5] = new GameBoard(button62, 'r', 62);
            buttons[7, 6] = new GameBoard(button63, ' ', 63);
            buttons[7, 7] = new GameBoard(button64, 'r', 64);

            FillImage();

        }
        GameBoard[,] buttons = new GameBoard[8, 8]; //declares an array of buttons
        private GameBoard moveToButton;
        private GameBoard currentButton;
        private GameBoard selectedButton;
        private char PlayerMark = 'r';
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button61;
        private Button button62;
        private Button button63;
        private Button button64;
        private Button button60;
        private Button button59;
        private Button button58;
        private Button button57;
        private Button button56;
        private Button button55;
        private Button button54;
        private Button button53;
        private Button button52;
        private Button button51;
        private Button button50;
        private Button button49;
        private Button button48;
        private Button button47;
        private Button button46;
        private Button button45;
        private Button button44;
        private Button button27;
        private Button button26;
        private Button button25;
        private Button button24;
        private Button button23;
        private Button button22;
        private Button button21;
        private Button button20;
        private Button button19;
        private Button button18;
        private Button button17;
        private Button button16;
        private Button button15;
        private Button button14;
        private Button button13;
        private Button button36;
        private Button button35;
        private Button button34;
        private Button button33;
        private Button button32;
        private Button button31;
        private Button button30;
        private Button button29;
        private Button button28;
        private Button button43;
        private Button button42;
        private Button button41;
        private Button button40;
        private Button button39;
        private Button button38;
        private Button button37;

        private void button65_Click(object sender, EventArgs e)
        {

           
        }
        private void FillImage()
        {
            try
            {
                for (int i = 0; i < 8; i++)
                    for (int j = 0; j < 8; j++)
                    {
                        if (buttons[i, j].Mark == 'r')
                        {
                            buttons[i, j].Button.Image = Draft.Properties.Resources.red3;
                        }
                        else if (buttons[i, j].Mark == 'b')
                        {
                            buttons[i, j].Button.Image = Draft.Properties.Resources.black2;
                        }
                        else
                        {
                            buttons[i, j].Button.Image = null;
                        }
                    }
            }
            catch (IndexOutOfRangeException) { }

        }
        private void button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                {
                    if (buttons[i, j].Button == sender)
                    {
                        selectedButton = buttons[i, j];
                        selectedButton.Button.BackColor = Color.Gray;
                    }
                }
            currentButton = Turn();
        }

        private GameBoard Turn()
        {
            return selectedButton;
        }

        private void ValidateMove()
        {
            moveToButton = Turn();
            currentButton.Button.BackColor = Color.Black;
            moveToButton.Button.BackColor = Color.Black;
            currentButton.Mark = ' ';
            currentButton.Mark = PlayerMark;


            FillImage();
        }


    }
}