using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab111
{
    public partial class Form2 : Form
    {
        public string Nume, Prenume;
        public double Salariu;
        public DateTimePicker dateTimePicker11;
        public string comboBox;
        public string CNA;
        public string id;

        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             this.Nume= textBox1.Text ;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
             this.Prenume= textBox2.Text ;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
             this.CNA= textBox3.Text ;

        }

        
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            this.Salariu = double.Parse(textBox4.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == null)
                MessageBox.Show("Selectati o valoare pentru angajat");
            else if (comboBox1.Text == "F")
                this.comboBox = "F";
            else if (comboBox1.Text == "M")
            {
                this.comboBox = "M";
            }
            ;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            this.id= textBox5.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validare campuri obligatorii
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Introduceți Numele!", "Atenție",
                MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Introduceți Prenumele!", "Atenție",
                MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            if (!double.TryParse(textBox4.Text, out _))
            {
                MessageBox.Show("Introduceți un salariu valid! (ex: 5500)", "Atenție",
                MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Selectați Sexul (F/M)!", "Atenție",
                MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            // Totul e valid — inchidem fereastra cu OK
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
