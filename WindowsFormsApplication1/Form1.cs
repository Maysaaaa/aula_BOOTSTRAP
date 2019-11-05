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
            textBox1.ReadOnly = true;
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
        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void button10_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text += 0;
        }

        private void soma_Click(object sender, EventArgs e)
        {
            try
            {
                v1 = double.Parse(textBox1.Text);
                op = '+';
                textBox1.Clear();
            }
            catch
            {

            }
        }

        private void subtração_Click(object sender, EventArgs e)
        {
            try
            {
                v1 = double.Parse(textBox1.Text);
                op = '-';
                textBox1.Clear();
            }
            catch
            {

            }
        }

        private void multiplicação_Click(object sender, EventArgs e)
        {
            try
            {
                v1 = double.Parse(textBox1.Text);
                op = 'x';
                textBox1.Clear();
            }
            catch
            {

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
            catch
            {
                MessageBox.Show("Visor Vazio!", "calculadora Diz",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            try
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
            catch
            {

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                v2 = double.Parse(textBox1.Text);
                v1 = v2 / 100;
                textBox1.Text += " % ";
                op = '%';
                textBox1.Clear();
            }
            catch
            {

            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            if (x < 0)
            {
                textBox1.Text = "Este valor não é valido.";
            }
            else
            {
                x = Math.Sqrt(x);
                textBox1.Text = x.ToString();
            }

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
                case '%':
                    R = v1 * v2;
                    break;
            }
            textBox1.Text = R.ToString();
        }

    }
}
