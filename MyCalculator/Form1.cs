using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void b1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            Input.Text = Input.Text + "1";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            Input.Text = Input.Text + "2";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            Input.Text = Input.Text + "3";
        }
        private void b4_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            Input.Text = Input.Text + "4";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            Input.Text = Input.Text + "5";
        }
        private void b6_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            Input.Text = Input.Text + "6";
        }
        private void b7_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            Input.Text = Input.Text + "7";
        }

        private void b8_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            Input.Text = Input.Text + "8";
        }

        private void b9_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            Input.Text = Input.Text + "9";
        }

        private void b0_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            Input.Text = Input.Text + "0";
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Input.Text = Input.Text + "/";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Input.Text = Input.Text + "*";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Input.Text = Input.Text + "-";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Input.Text = Input.Text + "+";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Input.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            char[] c = new char[Input.Text.Length - 1];
            Input.Text.CopyTo(0, c, 0, c.Length);
            Input.Text = new string(c);
        }

        private void Input_Enter(object sender, EventArgs e)
        {
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (Input.Text.Contains("+"))
            {
                string[] s = Input.Text.Split('+');
                int x = Convert.ToInt32(s[0]);
                int y = Convert.ToInt32(s[1]);

                int z = x + y;
                Input.Text = z.ToString();
                Output.Text = z.ToString();
            }
            else if (Input.Text.Contains("-"))
            {
                string[] s = Input.Text.Split('-');
                int x = Convert.ToInt32(s[0]);
                int y = Convert.ToInt32(s[1]);

                int z = x - y;
                Input.Text = z.ToString();
                Output.Text = z.ToString();
            }
            else if (Input.Text.Contains("/"))
            {
                string[] s = Input.Text.Split('/');
                int x = Convert.ToInt32(s[0]);
                int y = Convert.ToInt32(s[1]);

                int z = x / y;
                Input.Text = z.ToString();
                Output.Text = z.ToString();
            }
            else if (Input.Text.Contains("*"))
            {
                string[] s = Input.Text.Split('*');
                int x = Convert.ToInt32(s[0]);
                int y = Convert.ToInt32(s[1]);

                int z = x * y;
                Input.Text = z.ToString();
                Output.Text = z.ToString();
            }

        }

        private void Input_Click(object sender, EventArgs e)
        {
            Input.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Input.Text);
            Output.Text = Math.Sqrt(x).ToString();
            Input.Text = Output.Text;
        }

        private void Output_Click(object sender, EventArgs e)
        {

        }
    }
}

