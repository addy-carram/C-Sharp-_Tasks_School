using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab12
{
    public partial class Form3 : Form
    {
        public string id;

        public string Nume;
        public string Prenume;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {


        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.id = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.Nume = textBox2.Text;
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.Prenume = textBox3.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) &&
                !string.IsNullOrEmpty(textBox2.Text) &&
                !string.IsNullOrEmpty(textBox3.Text))
            {
                if (!int.TryParse(textBox1.Text, out int parsedId))
                {
                    MessageBox.Show("ID-ul trebuie să fie un număr!", "Atenție",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                id = parsedId.ToString();  
                Nume = textBox2.Text;
                Prenume = textBox3.Text;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Toate câmpurile trebuie completate!", "Atenție",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
