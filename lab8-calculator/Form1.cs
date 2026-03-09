using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8_calculator
{
    public partial class Form1 : Form

    {
        double value = 0;
        string operation = "";
        bool operation_pressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //button clear
            textBox1.Text = "0";
        }
        private void Number_click(object sender, EventArgs e)
        {
            if((textBox1.Text == "0") || (operation_pressed))
                textBox1.Clear();
            operation_pressed = false;
            Button b = (Button)sender;
            textBox1.Text = textBox1.Text + b.Text;

        }
        private void Operator_click(object sender, EventArgs e)
            {
                Button b = (Button)sender; 
                operation = b.Text;
                value = double.Parse(textBox1.Text);
                operation_pressed = true;
        }
        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            double second= Convert.ToDouble(textBox1.Text);
            switch (operation){
                case "+":
                    textBox1.Text = Convert.ToString(value + second);
                    break;
                case "-":
                    textBox1.Text = Convert.ToString(value - second);
                    break;
                case "*":
                    textBox1.Text = Convert.ToString(value * second);
                    break;
                case "/":
                    if (second != 0)
                    {
                        textBox1.Text = Convert.ToString(value / second);
                    }
                    else
                    {
                        MessageBox.Show("Cannot divide by zero");
                        textBox1.Text = "0";
                    }
                    break;

            }
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }
    }
}
