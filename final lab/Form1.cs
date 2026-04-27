using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_lab
{
    public partial class Form1 : Form
    {
        string connStr = @"Data Source=Adina\SQLEXPRESS;Initial Catalog=Eval;Integrated Security=True";
        DataTable fullData;
        public Form1()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Id.Text) || string.IsNullOrWhiteSpace(nume.Text)
                  || string.IsNullOrWhiteSpace(pin.Text) || string.IsNullOrWhiteSpace(pin2.Text)
                  || string.IsNullOrWhiteSpace(comboBox1.Text) || string.IsNullOrWhiteSpace(comboBox2.Text) )
                {
                    MessageBox.Show("Completeaza te rog spatiile goale");
                    return;
                }

                if (pin.Text.Length > 15 || pin.Text.Length == 0)
                    {
                    MessageBox.Show("Pinul trebuie sa aiba maxim 15 cifre");
                    return;
                }
                if (pin.Text.Length > 15 || pin.Text.Length == 0)
                {
                    MessageBox.Show("Pinul2 trebuie sa aiba  maxim 15 cifre");
                    return;
                }
                if (!double.TryParse(pin.Text, out double PIN))
                {
                    MessageBox.Show("PIN-ul trebuie sa fie un numar intreg");
                    return;
                }
                if (!double.TryParse(pin2.Text, out double PIN2))
                {
                    MessageBox.Show("PIN2-ul trebuie sa fie un numar intreg");
                    return;
                }
                if (!int.TryParse(Id.Text, out int id))
                {
                    MessageBox.Show("Id-ul trebuie sa fie un numar intreg");
                    return;
                }
                
                Person p = new Person();
                p.Id = id;
                p.Nume = nume.Text;
                p.PIN = PIN;
                p.PIN2 = PIN2;
                p.limba = comboBox1.Text;
                p.Tipul = comboBox2.Text;
                p.Optiuni = checkBox1.Checked;

                DialogResult result = MessageBox.Show(
                         "Are you sure you want to add?",
                         "Confirm add",
                         MessageBoxButtons.YesNo,
                         MessageBoxIcon.Warning
                     );
                if (result == DialogResult.Yes)
                {
                    addperson(p);
                    MessageBox.Show(" Person added succesuffully");
                    LoadUsers();
                    reset();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error to add the person"+ex.Message);
            }
        }
        private void reset()
        {
            Id.Text = "";
            nume.Text = "";
            pin.Text = "";
            pin2.Text = "";
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            checkBox1 = new CheckBox();

        }
        private void addperson(Person p)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Insert INTO inregistrare (Id, nume, PIN,PIN2,limba,Tipul,Optiuni) " +
                        "Values(@Id,@Nume,@PIN,@PIN2,@limba,@Tipul,@Optiuni)", conn);
                    cmd.Parameters.AddWithValue("@Id", p.Id);
                    cmd.Parameters.AddWithValue("@Nume", p.Nume);
                    cmd.Parameters.AddWithValue("@PIN", p.PIN);
                    cmd.Parameters.AddWithValue("@PIN2", p.PIN2);
                    cmd.Parameters.AddWithValue("@limba", p.limba);
                    cmd.Parameters.AddWithValue("@Tipul", p.Tipul);
                    cmd.Parameters.AddWithValue("@Optiuni", p.Optiuni);
                    cmd.ExecuteNonQuery();


                }
            }
            catch(Exception ex)
            {
                
                MessageBox.Show("Probleme la adaugare " + ex.Message);
            }
        }
        private void LoadUsers()
        {
            try { 
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                    conn.Open();
                    SqlDataAdapter adaptor = new SqlDataAdapter(
                        @"SELECT * FROM inregistrare",conn);
                    fullData = new DataTable();
                    adaptor.Fill(fullData);
                    dataGridView1.DataSource = fullData;

            }
            }
            catch(Exception ex)
            {
                MessageBox.Show(" Problem with connecting with database" +ex.Message);
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void refuz_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
