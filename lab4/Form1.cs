using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class MathQuiz : Form
    { int total = 0;
        public MathQuiz()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String totalInString = Convert.ToString(total);
            label23.Text=totalInString+" din 17";
            
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            label8.Text = "1";
            total = total + 1;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label9.Text = "1";
            total = total + 1;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            total = total + 1;

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            total = total + 1;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            total = total + 1;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            total = total + 1;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            total = total + 1;
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            total = total + 1;
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            total = total + 1;
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            total = total + 1;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            total = total + 1;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            total = total + 1;
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            total = total + 1;
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            total = total + 1;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            total = total + 1;
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            total = total + 1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text == "const")
            {
                total = total + 1;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
