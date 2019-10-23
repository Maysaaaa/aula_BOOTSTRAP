using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double v1, v2, R;
        char op;

        



        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text += 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text += 2;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text += 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text += 5;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text += 6;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text += 7;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text += 9;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text += 0;
        }

        private void soma_Click(object sender, EventArgs e)
        {
            v1 = double.Parse(textBox1.Text);
            op = '+';
            textBox1.Clear();
        }

        private void subtração_Click(object sender, EventArgs e)
        {
            v1 = double.Parse(textBox1.Text);
            op = '-';
            textBox1.Clear();
        }

        private void multiplicação_Click(object sender, EventArgs e)
        {
            v1 = double.Parse(textBox1.Text);
            op = 'x';
            textBox1.Clear();
        }

        private void divisão_Click(object sender, EventArgs e)
        {
            v1 = double.Parse(textBox1.Text);
            op = '/';
            textBox1.Clear();
        }

        private void resultado_Click(object sender, EventArgs e)
        {
            v2 = double.Parse(textBox1.Text);
            switch (op)
            {
                case '+':
                    R = v1 + v2;
                    break;
                case '-':
                    R = v1 - v2;
                    break;
                case 'x':
                    R = v1 * v2;
                    break;
                case '/':
                    R = v1 / v2;
                    break;
            }
            textBox1.Text = R.ToString();
        }

    }
}
