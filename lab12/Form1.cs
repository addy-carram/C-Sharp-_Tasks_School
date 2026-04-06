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

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 ang = new Form2();

            if (ang.ShowDialog() == DialogResult.OK)
            {
                switch (ang.SelectedTable)
                {
                    case "Carti":
                        this.carteTableAdapter.Fill(this.bibliotecaDataSet.Carte);
                        cititorBindingSource.DataSource = bibliotecaDataSet;
                        cititorBindingSource.DataMember = "Carte";
                        break;
                    case "Cititori":
                        this.cititorTableAdapter.Fill(this.bibliotecaDataSet.Cititor);
                        cititorBindingSource.DataSource = bibliotecaDataSet;
                        cititorBindingSource.DataMember = "Cititor";
                        break;
                    case "Contracte":
                        this.chirieTableAdapter.Fill(this.bibliotecaDataSet.Chirie);
                        cititorBindingSource.DataSource = bibliotecaDataSet;
                        cititorBindingSource.DataMember = "Chirie";
                        break;
                }
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            Form3 ang = new Form3();

            if (ang.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var conn = cititorTableAdapter.Connection;
                    string sql = "";

                    sql = "INSERT INTO Cititor (Id_cititor, Nume, Prenume) " +
                          "VALUES (@id, @Nume, @Prenume)";


                    using (var cmd = new System.Data.SqlClient.SqlCommand(sql, conn))
                    {
                        // SAFE: parameters are never interpreted as SQL
                        cmd.Parameters.AddWithValue("@id", int.Parse(ang.id));
                        cmd.Parameters.AddWithValue("@Nume", ang.Nume);
                        cmd.Parameters.AddWithValue("@Prenume", ang.Prenume);

                        if (conn.State == ConnectionState.Closed)
                            conn.Open();

                        cmd.ExecuteNonQuery();

                        if (conn.State == ConnectionState.Open)
                            conn.Close();
                    }
                    this.cititorTableAdapter.Fill(this.bibliotecaDataSet.Cititor);
                    MessageBox.Show("Înregistrarea a fost adăugată cu succes!",
                        "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare: " + ex.Message);
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectați un rând!", "Atenție",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Sigur doriți să ștergeți?", "Confirmare",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                    cititorTableAdapter.Update(bibliotecaDataSet.Cititor);
                    carteTableAdapter.Update(bibliotecaDataSet.Carte);
                    chirieTableAdapter.Update(bibliotecaDataSet.Chirie);
                    MessageBox.Show("Șters cu succes!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare: " + ex.Message);
                }
            }
        }
        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form4 ang = new Form4();
            if (ang.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var conn = cititorTableAdapter.Connection;
                    string sql = "DELETE FROM Cititor WHERE Id_cititor = @id";
                    using (var cmd = new System.Data.SqlClient.SqlCommand(sql, conn))
                    {
                        // SAFE: parameters are never interpreted as SQL
                        cmd.Parameters.AddWithValue("@id", int.Parse(ang.id));
                        if (conn.State == ConnectionState.Closed)
                            conn.Open();
                        cmd.ExecuteNonQuery();
                        if (conn.State == ConnectionState.Open)
                            conn.Close();
                    }
                    this.cititorTableAdapter.Fill(this.bibliotecaDataSet.Cititor);
                    MessageBox.Show("Înregistrarea a fost ștearsă cu succes!",
                        "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare: " + ex.Message);
                }
            }
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            Form5 ang = new Form5();
            if (ang.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var conn = cititorTableAdapter.Connection;
                    string sql = "UPDATE Cititor SET Nume = @Nume, Prenume = @Prenume WHERE Id_cititor = @id";
                    using (var cmd = new System.Data.SqlClient.SqlCommand(sql, conn))
                    {
                        
                        cmd.Parameters.AddWithValue("@id", int.Parse(ang.id));
                        cmd.Parameters.AddWithValue("@Nume", ang.Nume);
                        cmd.Parameters.AddWithValue("@Prenume", ang.Prenume);
                        if (conn.State == ConnectionState.Closed)
                            conn.Open();
                        cmd.ExecuteNonQuery();
                        if (conn.State == ConnectionState.Open)
                            conn.Close();
                    }
                    this.cititorTableAdapter.Fill(this.bibliotecaDataSet.Cititor);
                    MessageBox.Show("Înregistrarea a fost actualizată cu succes!",
                        "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare: " + ex.Message);
                }
            }
        }
    }
}
