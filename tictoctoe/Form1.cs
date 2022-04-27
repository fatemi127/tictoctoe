using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Button[,] dbu;
        int ply, i, j;
        public Form1()
        {
            InitializeComponent();

            dbu = new Button[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Button dbu = new Button();
                    dbu.Click += new EventHandler(dbu_click);

                    dbu.Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom);
                    tableLayoutPanel1.Controls.Add(dbu, i, j);
                }
            }



            newgame();
        }
       


        private void dbu_click(object sender, EventArgs e)
        {
            MessageBox.Show("Ok");
        }
        private void newgame()
        {
            ply = 1;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    dbu[i, j].Text = "";
                }
            }
        }


        private void button9_Click(object sender, EventArgs e)
        {
            Button this_button = (sender as Button);
            if (this_button.Text == "")
            {
                if (ply == 1)
                {
                    this_button.Text = "X";
                    this_button.ForeColor = Color.DarkGreen;
                    this_button.BackColor = Color.LightGreen;

                    ply = 2;
                }
                else if (ply == 2)
                {
                    this_button.Text = "O";
                    this_button.ForeColor = Color.Red;
                    this_button.BackColor = Color.Pink;
                    ply = 1;
                }
                chekgame();
            }
        }

       
        
        private void chekgame()
        {
            if (dbu[0, 0].Text == "X" && dbu[0, 1].Text == "X" && dbu[0, 2].Text == "X")
            {
                MessageBox.Show("بازیکن شماره یک برنده شد");
                newgame();
            }
            else if (dbu[1, 0].Text == "X" && dbu[1, 1].Text == "X" && dbu[1, 2].Text == "X")
            {
                MessageBox.Show("بازیکن شماره یک برنده شد");
                newgame();
            }
            else if (dbu[2, 0].Text == "X" && dbu[2, 1].Text == "X" && dbu[2, 2].Text == "X")
            {
                MessageBox.Show("بازیکن شماره یک برنده شد");
                newgame();
            }

            else if (dbu[0, 0].Text == "X" && dbu[1, 0].Text == "X" && dbu[2, 0].Text == "X")
            {
                MessageBox.Show("بازیکن شماره یک برنده شد");
                newgame();
            }
            else if (dbu[0, 1].Text == "X" && dbu[1, 1].Text == "X" && dbu[1, 2].Text == "X")
            {
                MessageBox.Show("بازیکن شماره یک برنده شد");
                newgame();
            }
            else if (dbu[2, 0].Text == "X" && dbu[2, 1].Text == "X" && dbu[2, 2].Text == "X")
            {
                MessageBox.Show("بازیکن شماره یک برنده شد");
                newgame();
            }

            else if (dbu[0, 0].Text == "X" && dbu[1, 1].Text == "X" && dbu[2, 2].Text == "X")
            {
                MessageBox.Show("بازیکن شماره یک برنده شد");
                newgame();
            }
            else if (dbu[0, 2].Text == "X" && dbu[1, 1].Text == "X" && dbu[2, 0].Text == "X")
            {
                MessageBox.Show("بازیکن شماره یک برنده شد");
                newgame();
            }
            else if (dbu[0, 0].Text == "O" && dbu[0, 1].Text == "O" && dbu[0, 2].Text == "O")
            {
                MessageBox.Show("بازیکن شماره دو برنده شد");
                newgame();
            }
            else if (dbu[1, 0].Text == "O" && dbu[1, 1].Text == "O" && dbu[1, 2].Text == "O")
            {
                MessageBox.Show("بازیکن شماره دو برنده شد");
                newgame();
            }
            else if (dbu[2, 0].Text == "O" && dbu[2, 1].Text == "O" && dbu[2, 2].Text == "O")
            {
                MessageBox.Show("بازیکن شماره دو برنده شد");
                newgame();
            }
            else if (dbu[0, 0].Text == "O" && dbu[1, 0].Text == "O" && dbu[2, 0].Text == "O")
            {
                MessageBox.Show("بازیکن شماره دو برنده شد");
                newgame();
            }
            else if (dbu[0, 1].Text == "O" && dbu[1, 1].Text == "O" && dbu[1, 2].Text == "O")
            {
                MessageBox.Show("بازیکن شماره دو برنده شد");
                newgame();
            }
            else if (dbu[2, 0].Text == "O" && dbu[2, 1].Text == "O" && dbu[2, 2].Text == "O")
            {
                MessageBox.Show("بازیکن شماره دو برنده شد");
                newgame();
            }

            else if (dbu[0, 0].Text == "O" && dbu[1, 1].Text == "O" && dbu[2, 2].Text == "O")
            {
                MessageBox.Show("بازیکن شماره دو برنده شد");
                newgame();
            }
            else if (dbu[0, 2].Text == "O" && dbu[1, 1].Text == "O" && dbu[2, 0].Text == "O")
            {
                MessageBox.Show("بازیکن شماره دو برنده شد");
                newgame();
            }
            else if (dbu[0, 0].Text != "" && dbu[0, 1].Text != "" && dbu[0, 2].Text != "" && dbu[1, 0].Text != "" && dbu[1, 1].Text != "" && dbu[1, 2].Text != "" && dbu[2, 0].Text != "" && dbu[2, 1].Text != "" && dbu[2, 2].Text != "")
            {
                MessageBox.Show("مساوی امتیازات برابر هستند");
                newgame();
            }

        }

 

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            newgame();

        }
    }
}
