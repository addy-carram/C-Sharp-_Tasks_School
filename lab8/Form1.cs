using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private List<Student> lista = new List<Student>();
        Student s = new Student();


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //adaugam elementele introduse din Form intr-o lista generica
            try
            {
                s = new Student(textBox1.Text, Byte.Parse(numericUpDown1.Text), Byte.Parse(comboBox1.Text), Byte.Parse(comboBox2.Text),
                Byte.Parse(comboBox3.Text), Byte.Parse(comboBox4.Text), Byte.Parse(comboBox5.Text),
                Byte.Parse(comboBox6.Text));
                lista.Add(s);

                // Clear the input fields after adding
                textBox1.Clear();
                numericUpDown1.Value = 0;
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                comboBox3.SelectedIndex = -1;
                comboBox4.SelectedIndex = -1;
                comboBox5.SelectedIndex = -1;
                comboBox6.SelectedIndex = -1;

                MessageBox.Show("Student adaugat cu succes!", "Succes");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Introduceti datele corect", "Nu au fost introduse datele corect");
            }
        }
        //Functia pentru sortarea dupa nume
        public int ComparaNume(Student x, Student y)
        {
            return string.Compare(x.NumeStudent, y.NumeStudent);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lista.Count == 0)
            {
                MessageBox.Show("Introduceti datele", "Nu au fost introduse date", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                return;
            }

            // Clear the listView before adding sorted items
            listView1.Items.Clear();

            //Sortam elementele dupa nume si le afisam in MediulDeAfisare
            lista.Sort(ComparaNume);
            for (int i = 0; i < lista.Count; i++)
            {
                listView1.Items.Add(lista[i].AfisareStudent());
            }
        }
        //Functia pentru sortarea dupa medie
        public int ComparaMedie(Student x, Student y)
        {
            if (x.Medie() > y.Medie())
                return 1;
            else if (x.Medie() == y.Medie())
                return 0;
            else
                return -1;
        }
        //Afisarea studentilor in forma sortata dupa medie in urma tastarii butonulu respectiv
        private void button3_Click(object sender, EventArgs e)
        {
            if (lista.Count == 0)
            {
                MessageBox.Show("Introduceti datele", "Nu au fost introduse date");
                return;
            }

            // Clear the listView before adding sorted items
            listView1.Items.Clear();

            lista.Sort(ComparaMedie);
            for (int i = 0; i < lista.Count; i++)
            {
                listView1.Items.Add(lista[i].AfisareStudent());
            }
        }
        //Stergerea datelor din MediulDeAfisare dupa tastarea butonului Delete
        private void button6_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }
        //afisarea studentilor dupa anul de studiu 
        private void button4_Click(object sender, EventArgs e)
        {
            // Clear listView before adding filtered results
            listView1.Items.Clear();

            for (int i = 0; i < lista.Count; i++)
            {
                try
                {
                    if (Byte.Parse(comboBox7.Text) == lista[i].AnStudiu)
                        listView1.Items.Add(lista[i].AfisareStudent());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Nu a fost introdus anul");
                    return;
                }

            }
            if (listView1.Items.Count == 0) listView1.Items.Add("Nu exista astfel de student!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Clear listView before adding filtered results
            listView1.Items.Clear();

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].NumeStudent == textBox2.Text)
                    listView1.Items.Add(lista[i].AfisareStudent());
            }
            if (listView1.Items.Count == 0) listView1.Items.Add("Nu exista astfel de student!");
        }
    }

    public class Person
    {
        protected string nume;
        protected byte varsta;
        public Person() { }
        public Person(string nume, byte varsta)
        {
            this.nume = nume;
            this.varsta = varsta;
        }
    }

    public class Student : Person
    {
        private byte[] note = new byte[5];
        public byte AnStudiu;
        public string NumeStudent;
        public Student() : base() { }
        public Student(string nume, byte varsta, byte AnStudiu, byte nota1, byte
        nota2, byte nota3, byte nota4, byte nota5) : base(nume, varsta)
        {
            NumeStudent = nume;
            this.varsta = varsta;
            this.AnStudiu = AnStudiu;
            note[0] = nota1;
            note[1] = nota2;
            note[2] = nota3;
            note[3] = nota4;
            note[4] = nota5;
        }

        public float Medie()
        {
            byte sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += note[i];
            }
            return (float)sum / 5;
        }
        public string AfisareStudent()
        {
            return nume + " " + varsta + " " + AnStudiu + " " + Medie() + "\n";
        }
    }
}