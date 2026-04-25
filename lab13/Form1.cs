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

namespace lab13
{
    public partial class Form1 : Form
    {
        string connStr = @"Data Source=Adina\SQLEXPRESS;Initial Catalog=CEITI;Integrated Security=True";

        DataTable fullData, fullData1,fullData2;
        public Form1()
        {
            InitializeComponent();
            LoadPupil();
            LoadSchedual();
            statistic();

        }
        private void LoadPupil()
        {
            try
            {
                string connStr = @"Data Source=Adina\SQLEXPRESS;Initial Catalog=CEITI;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(
                        @"Select * from Scheduale", conn);

                    fullData1 = new DataTable();
                    adapter.Fill(fullData1);
                    dataGridView2.DataSource = fullData1;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadSchedual()
        {
            try
            {
                string connStr = @"Data Source=Adina\SQLEXPRESS;Initial Catalog=CEITI;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(
                        @"Select * from Pupils", conn);

                    fullData = new DataTable();
                    adapter.Fill(fullData);
                    dataGridView1.DataSource = fullData;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void statistic()
        {
            try
            {
                string connStr = @"Data Source=Adina\SQLEXPRESS;Initial Catalog=CEITI;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    SqlCommand query= new SqlCommand(
                        @"SELECT count(*) from Pupils", conn);
                    SqlCommand query1 = new SqlCommand(
                        @"SELECT count(*) from Teacher", conn);
                    SqlCommand query2 = new SqlCommand(
                        @"SELECT count(*) from Objects_S", conn);
                    SqlCommand query3 = new SqlCommand(
                        @"SELECT count(*) from Class", conn);
                    int countPupils=Convert.ToInt32(query.ExecuteScalar());
                    int countTeachers=Convert.ToInt32(query1.ExecuteScalar());
                    int countObjects=Convert.ToInt32(query2.ExecuteScalar());
                    int countClasses=Convert.ToInt32(query3.ExecuteScalar());
                    label16.Text = countPupils.ToString();
                    label17.Text = countTeachers.ToString();
                    label18.Text = countObjects.ToString();
                    label19.Text = countClasses.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("analitics "+ex.Message);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

            }catch(Exception ex)
            {
                MessageBox.Show("adaug eroare "+ex.Message)
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex.ToString())
            {

                case "1":
                    {
                        using (SqlConnection conn = new SqlConnection(connStr))
                        {
                            conn.Open();
                            SqlDataAdapter adapter = new SqlDataAdapter(
                                @"Select * from Scheduale where id_class=1", conn);
                            fullData2 = new DataTable();
                            adapter.Fill(fullData2);
                            dataGridView2.DataSource = fullData2;
                        }
                        break;
                    }
                case "2":
                    {
                        using (SqlConnection conn = new SqlConnection(connStr))
                        {
                            conn.Open();
                            SqlDataAdapter adapter = new SqlDataAdapter(
                                @"Select * from Scheduale where id_class=2", conn);
                            fullData2 = new DataTable();
                            adapter.Fill(fullData2);
                            dataGridView2.DataSource = fullData2;
                        }
                        break;
                    }
                case "3":
                    {
                        using (SqlConnection conn = new SqlConnection(connStr))
                        {
                            conn.Open();
                            SqlDataAdapter adapter = new SqlDataAdapter(
                                @"Select * from Scheduale where id_class=3", conn);
                            fullData2 = new DataTable();
                            adapter.Fill(fullData2);
                            dataGridView2.DataSource = fullData2;
                        }
                        break;
                    }
                case "4":
                    {
                        using (SqlConnection conn = new SqlConnection(connStr))
                        {
                            conn.Open();
                            SqlDataAdapter adapter = new SqlDataAdapter(
                                @"Select * from Scheduale where id_class=4", conn);
                            fullData2 = new DataTable();
                            adapter.Fill(fullData2);
                            dataGridView2.DataSource = fullData2;
                        }
                        break;
                    }
                case "5":
                    {
                        using (SqlConnection conn = new SqlConnection(connStr))
                        {
                            conn.Open();
                            SqlDataAdapter adapter = new SqlDataAdapter(
                                @"Select * from Scheduale where id_class=5", conn);
                            fullData2 = new DataTable();
                            adapter.Fill(fullData2);
                            dataGridView2.DataSource = fullData2;
                        }
                        break;
                    }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
