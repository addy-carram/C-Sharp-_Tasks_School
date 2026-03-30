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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotecaDataSet.Cititor' table. You can move, or remove it, as needed.
            this.cititorTableAdapter.Fill(this.bibliotecaDataSet.Cititor);
            // TODO: This line of code loads data into the 'bibliotecaDataSet.Chirie' table. You can move, or remove it, as needed.
            this.chirieTableAdapter.Fill(this.bibliotecaDataSet.Chirie);
            // TODO: This line of code loads data into the 'bibliotecaDataSet.Carte' table. You can move, or remove it, as needed.
            this.carteTableAdapter.Fill(this.bibliotecaDataSet.Carte);

        }
    }
}
