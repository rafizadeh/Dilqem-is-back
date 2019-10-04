using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {
                    }
        int pl1 = 0;
        int pl2 = 0;
        int totpl1 = 0;
        int totpl2 = 0;
        private void Button1_Click(object sender, EventArgs e)
        {
            Random s = new Random(); 
            int dice1 = s.Next(1, 7);
            int dice2 = s.Next(1, 7);

            pictureBox1.ImageLocation = "C:\\Users\\Student.REKLAB244-15\\Desktop\\dice\\dice\\img\\" + Convert.ToString(dice1) + ".png";
            pictureBox2.ImageLocation = "C:\\Users\\Student.REKLAB244-15\\Desktop\\dice\\dice\\img\\" + Convert.ToString(dice2) + ".png";
            label1.Text = Convert.ToString(dice1);
            label2.Text = Convert.ToString(dice2);
            pl1 += dice1 + dice2;
            label5.Text = Convert.ToString(pl1);
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            Random s = new Random();
            int dice1 = s.Next(1, 7);
            int dice2 = s.Next(1, 7);
            pictureBox1.ImageLocation = "C:\\Users\\Student.REKLAB244-15\\Desktop\\dice\\dice\\img\\" + Convert.ToString(dice1) + ".png";
            pictureBox2.ImageLocation = "C:\\Users\\Student.REKLAB244-15\\Desktop\\dice\\dice\\img\\" + Convert.ToString(dice2) + ".png";

            label3.Text = Convert.ToString(dice1);
            label4.Text = Convert.ToString(dice2);
            pl2 += dice1 + dice2;
            label6.Text = Convert.ToString(pl2);

            if (pl2 >= 100 && pl2 > pl1)
            {
                totpl2++;
                label9.Text = Convert.ToString(totpl1);
                label10.Text = Convert.ToString(totpl2);
                MessageBox.Show("Player2 Win: " + Convert.ToString(pl2) + " point");
                pl1 = 0;
                pl2 = 0;
                label5.Text = Convert.ToString(pl1);
                label6.Text = Convert.ToString(pl2);
            }
            else if(pl1 >= 100 && pl1 > pl2)
            {

                totpl1++;
                label9.Text = Convert.ToString(totpl1);
                label10.Text = Convert.ToString(totpl2);
                MessageBox.Show("Player1 Win: " + Convert.ToString(pl1) + " point");
                pl1 = 0;
                pl2 = 0;
                label5.Text = Convert.ToString(pl1);
                label6.Text = Convert.ToString(pl2);

            }

            button2.Enabled = false;
            button1.Enabled = true;
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "")
            {
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = false;
                groupBox1.Text = textBox1.Text;
                groupBox2.Text = textBox2.Text;
                label7.Text = textBox1.Text + ": ";
                label8.Text = textBox2.Text + ": ";

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
