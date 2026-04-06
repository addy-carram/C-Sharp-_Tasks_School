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
    public partial class Form4 : Form
    {
        public string id;
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Introduceți ID-ul!", "Atenție",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBox1.Text, out int parsedId))
            {
                MessageBox.Show("ID-ul trebuie să fie un număr!", "Atenție",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            id = parsedId.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
