using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int num1 = 0;

        private void label1_Click(object sender, EventArgs e)
        {
            
            label1.BackColor = Color.Magenta;
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;



        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Magenta;
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            num1++;
            this.Text = num1.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            string x = "Tack för att du besökte oss!";

            label5.Text = x;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label5.Text = "label5";
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            Random random = new Random();

            int num2 = random.Next(1, 100);
            int num3 = random.Next(1, 100);

            label6.Location = new Point(num2, num3);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;


            System.Diagnostics.Process.Start("http://www.microsoft.com");
        }
    }
}
