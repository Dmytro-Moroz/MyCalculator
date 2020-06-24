using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public string opertaion;
        public string number;
        public bool clearPoint;
        public Form1()
        {
            clearPoint = false;
            InitializeComponent();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (clearPoint)
            {
                clearPoint = false;
                textBox1.Text = "";
            }
            Button button = (Button)sender;
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            else
            {
                textBox1.Text = textBox1.Text + button.Text;
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            opertaion = button.Text;
            number = textBox1.Text;
            clearPoint = true;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double result1, result2; 
            double mainResult = 0;
            result1 = Convert.ToDouble(number);
            result2 = Convert.ToDouble(textBox1.Text);
            if (opertaion == "+")
            {
                mainResult = result1 + result2;
            }
            if (opertaion == "-")
            {
                mainResult = result1 - result2;
            }
            if (opertaion == "*")
            {
                mainResult = result1 * result2;
            }
            if (opertaion == "/")
            {
                mainResult = result1 / result2;
            }
            if (opertaion == "%")
            {
                mainResult = result1 * result2 / 100;
            }

            //opertaion = "=";
            clearPoint = true;
            textBox1.Text = mainResult.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double num;
            double result = 0;
            num = Convert.ToDouble(textBox1.Text);
            result = Math.Sqrt(num);
            textBox1.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double num;
            double result = 0;
            num = Convert.ToDouble(textBox1.Text);
            result = Math.Pow(num, 2);
            textBox1.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double num;
            double result = 0;
            num = Convert.ToDouble(textBox1.Text);
            result = 1/num;
            textBox1.Text = result.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            double num;
            double result = 0;
            num = Convert.ToDouble(textBox1.Text);
            result = -num;
            textBox1.Text = result.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
                textBox1.Text = textBox1.Text + ",";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
        }
    }
}
