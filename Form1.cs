using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        int counter = 0,i=0;
        Boolean t;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        { }
        public bool selectbutton(Button b1,Button b2,Button b3)
        {
        
            if (b1.Text == "X" && b2.Text == "X" && b3.Text == "X" ||
                b1.Text == "0" && b2.Text == "0" && b3.Text == "0")
            {
                t = true;
                Button[] arratbutton = new Button[9] { box1, box2, box, box4, box8, box7, box3, box6, box9 };
                for (int p = 0; p < 9; p++)
                {
                    arratbutton[p].Enabled = false;
                }
                result.Text = "You won the game";
                result.ForeColor = Color.Green;
                player_1.ResetText();
                player_2.ResetText();
            }
            else
            {

                t = false;
            }
            return t;
        }

        public void selectcolor(Button b1, Button b2, Button b3)
        {
            b1.BackColor = Color.LawnGreen;
            b2.BackColor = Color.LawnGreen;
            b3.BackColor = Color.LawnGreen;
        }
        public void drawgame(int i)//method for when draw the game
        {
            if (i == 8)
            {
                if (t==false)
                {
                    result.Text = "draw game";
                    result.ForeColor = Color.Red;
                    player_1.ResetText();
                    player_2.ResetText();
                }
            }
        }
        public void display(Button b)
        {
            if (counter == 0)
            {
                player_1.Text = "player X";
                player_1.ForeColor = Color.RoyalBlue;
                player_2.ForeColor = Color.Black;
             
                b.Text = "X";
                counter++;
                b.Enabled = false;
            }
            else if (counter == 1)
            {
                player_2.Text = "player O";
                player_2.ForeColor = Color.RoyalBlue;
                player_1.ForeColor = Color.Black;
                b.Text = "0";
                counter--;
                b.Enabled = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            drawgame(i++);
            display(box1);
            if (selectbutton(box1, box2, box3))
            {
                selectcolor(box1, box2, box3);
            }
            else if (selectbutton(box1, box, box9))
            {
                selectcolor(box1, box, box9);
            }
            else if (selectbutton(box1, box4, box7))
            {
                selectcolor(box1, box4, box7);
            }
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            display(box2);
            if (selectbutton(box1, box2, box3))
            {
                selectcolor(box1, box2, box3);
            }
            else if (selectbutton(box2, box, box8))
            {
                selectcolor(box2, box, box8);
            }
            drawgame(i++);

        }
        private void button7_Click(object sender, EventArgs e)
        {
            display(box3);
            if (selectbutton(box3, box, box7))
            {
                selectcolor(box3, box, box7);
            }
            else if (selectbutton(box1, box2, box3))
            {
                selectcolor(box1, box2, box3);
            }
            else if (selectbutton(box3, box6, box9))
            {
                selectcolor(box3, box6, box9);
            }
            drawgame(i++);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            display(box4);
            if (selectbutton(box1, box4, box7))
            {
                selectcolor(box1, box4, box7);
            }
            else if (selectbutton(box4, box, box6))
            {
                selectcolor(box4, box, box6);
            }
            drawgame(i++);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            display(box);
            if (selectbutton(box1, box, box9))
            {
                selectcolor(box1, box, box9);
            }
            else if (selectbutton(box3, box, box7))
            {
                selectcolor(box3, box, box7);
            }
            else if (selectbutton(box4, box, box6))
            {
                selectcolor(box4, box, box6);
            }
            else if (selectbutton(box2, box, box8))
            {
                selectcolor(box2, box, box8);
            }
            drawgame(i++);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            display(box6);
            if (selectbutton(box3, box6, box9))
            {
                selectcolor(box3, box6, box9);
            }
            else if (selectbutton(box4, box, box6))
            {
                selectcolor(box4, box, box6);
            }
            drawgame(i++);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            display(box7);
            if (selectbutton(box1, box4, box7))
            {
                selectcolor(box1, box4, box7);
            }
            else if (selectbutton(box3, box, box7))
            {
                selectcolor(box3, box, box7);
            }
            else if (selectbutton(box7, box8, box9))
            {
                selectcolor(box7, box8, box9);
            }
            drawgame(i++);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            display(box8);
            if (selectbutton(box7, box8, box9))
            { 
            selectbutton(box7, box8, box9);
            }
            else if (selectbutton(box2, box, box8))
            {
                selectcolor(box2, box, box8);
            }
            drawgame(i++);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            display(box9);
            if (selectbutton(box1, box, box9))
            {
                selectcolor(box1, box, box9);
            }
            else if (selectbutton(box3, box6, box9))
            {
                selectcolor(box3, box6, box9);
            }
            else if (selectbutton(box7, box8, box9))
            {
                selectcolor(box7, box8, box9);
            }
            drawgame(i++);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            counter = 0;
            i = 0;
            player_1.ResetText();
            player_2.ResetText();
            result.ResetText();
            Button[] arratbutton = new Button[9] { box1, box2, box, box4, box8, box7, box3, box6, box9 };
            for (int l = 0; l < 9; l++)
            {
                arratbutton[l].Enabled = true;
                arratbutton[l].Text = "";
                arratbutton[l].BackColor = Color.White;
            }
        }
    }
}
