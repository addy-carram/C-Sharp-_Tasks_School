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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'comoanie_ITDataSet.Angajati' table. You can move, or remove it, as needed.
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.angajatiTableAdapter.Fill(this.comoanie_ITDataSet.Angajati);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 ang= new Form2();
            
            if (ang.ShowDialog() == DialogResult.OK)
            {
                var conn = angajatiTableAdapter.Connection;

                string sql = "INSERT INTO Angajati (IdAngajat,Nume, Prenume,CNP,Sex,Salariu) " +
                             "VALUES (@ID,@Nume, @Prenume, @CNA, @Sex, @Salariu)";

                using (var cmd = new System.Data.SqlClient.SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", ang.id);
                    cmd.Parameters.AddWithValue("@Nume", ang.Nume);
                    cmd.Parameters.AddWithValue("@Prenume", ang.Prenume);
                    cmd.Parameters.AddWithValue("@CNA", ang.CNA);
                    cmd.Parameters.AddWithValue("@Sex", ang.comboBox);
                    cmd.Parameters.AddWithValue("@Salariu", ang.Salariu);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                // Reincarcam DataGridView
                angajatiTableAdapter.Fill(this.comoanie_ITDataSet.Angajati);

                MessageBox.Show($"Angajatul {ang.Nume} {ang.Prenume} a fost adăugat!",
                    "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
