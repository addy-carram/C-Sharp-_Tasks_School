using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void mainbtn_Click(object sender, EventArgs e)
        {
            //double i=int.Parse(textBox1.Text);
            //if (fromcomboBox1.SelectedItem.ToString() == "MDL" &&
            //    tocomboBox2.SelectedItem.ToString() == "USD" )
            //{
            //    double conver = i / 16.56;
            //    label5.Text = "Suma obtinuta: " + conver + "\t$";
            //}
            double i = int.Parse(textBox1.Text);
            if (i > 0)
            {
                textBox1.BackColor = Color.DarkOliveGreen;
                label5.BackColor=Color.White;
                if (comboBox1.SelectedItem.ToString() == "MDL" &&
                    comboBox2.SelectedItem.ToString() == "USD")
                {
                    double conver = i / 16.56;
                    label5.Text = "Suma obținuta: " + conver + "\t $";
                    label12.Text = "MDL";
                    label13.Text = "USD";
                    label14.Text = "0";
                    label15.Text = "" + conver;

                }
                if (comboBox1.SelectedItem == "MDL" && comboBox2.SelectedItem == "EUR")
                {
                    double conver = i / 19.84;
                    label5.Text = "Suma obținuta: " + conver + "\t euro";
                    label12.Text = "MDL";
                    label13.Text = "EUR";
                    label14.Text = "0";
                    label15.Text = "" + conver;
                }
                if (comboBox1.SelectedItem.ToString() == "EUR" &&
                    comboBox2.SelectedItem.ToString() == "MDL")
                {
                    double conver = i * 19.84;
                    label5.Text = "Suma obținuta: " + conver + "\t Lei";
                    label12.Text = "EUR";
                    label13.Text = "MDL";
                    label14.Text = "0";
                    label15.Text = "" + conver;
                }
                if (comboBox1.SelectedItem.ToString() == "USD" &&
                    comboBox2.SelectedItem.ToString() == "MDL")
                {
                    double conver = i * 16.56;
                    label5.Text = "Suma obținuta: " + conver + "\t Lei";
                    label12.Text = "USD";
                    label13.Text = "MDL";
                    label14.Text = "0";
                    label15.Text = "" + conver;
                }
                if (comboBox1.SelectedItem.ToString() == "EUR" &&
                    comboBox2.SelectedItem.ToString() == "USD")
                {
                    double conver = i * 1.17;
                    label5.Text = "Suma obținuta: " + conver + "\t USD";
                    label12.Text = "EUR";
                    label13.Text = "USD";
                    label14.Text = "0";
                    label15.Text = "" + conver;
                }
                if (comboBox1.SelectedItem.ToString() == "RON" &&
                    comboBox2.SelectedItem.ToString() == "EUR")
                {
                    double conver = i * 0.2;
                    label5.Text = "Suma obținuta: " + conver + "\t EUR";
                    label12.Text = "RON";
                    label13.Text = "EUR";
                    label14.Text = "0";
                    label15.Text = "" + conver;
                }

                if (comboBox1.SelectedItem.ToString() == "EUR" &&
                    comboBox2.SelectedItem.ToString() == "RON")
                {
                    double conver = i * 5.10;
                    label5.Text = "Suma obținuta: " + conver + "\t RON";
                    label12.Text = "EUR";
                    label13.Text = "RON";
                    label14.Text = "0";
                    label15.Text = "" + conver;
                }
                if (comboBox1.SelectedItem.ToString() == "MDL" &&
                    comboBox2.SelectedItem.ToString() == "RON")
                {
                    double conver = i * 0.25;
                    label5.Text = "Suma obținuta: " + conver + "\t RON";
                    label12.Text = "MDL";
                    label13.Text = "RON";
                    label14.Text = "0";
                    label15.Text = "" + conver;
                }
                if (comboBox1.SelectedItem.ToString() == "RON" &&
                    comboBox2.SelectedItem.ToString() == "MDL")
                {
                    double conver = i * 3.8;
                    label5.Text = "Suma obținuta: " + conver + "\t MDL";
                    label12.Text = "RON";
                    label13.Text = "MDL";
                    label14.Text = "0";
                    label15.Text = "" + conver;
                }
                if (comboBox1.SelectedItem.ToString() == "RON" &&
                    comboBox2.SelectedItem.ToString() == "USD")
                {
                    double conver = i * 0.25;
                    label5.Text = "Suma obținuta: " + conver + "\t USD";
                    label12.Text = "RON";
                    label13.Text = "USD";
                    label14.Text = "0";
                    label15.Text = "" + conver;
                }

                if (comboBox1.SelectedItem.ToString() == "USD" &&
                    comboBox2.SelectedItem.ToString() == "RON")
                {
                    double conver = i * 4.3;
                    label5.Text = "Suma obținuta: " + conver + "\t RON";
                    label12.Text = "USD";
                    label13.Text = "RON";
                    label14.Text = "0";
                    label15.Text = "" + conver;
                }
                if (comboBox1.SelectedItem.ToString() == "MDL" &&
                    comboBox2.SelectedItem.ToString() == "RUBLE")
                {
                    double conver = i * 4.5;
                    label5.Text = "Suma obținuta: " + conver + "\t RUBLE";
                    label12.Text = "MDL";
                    label13.Text = "RUBLE";
                    label14.Text = "0";
                    label15.Text = "" + conver;
                }
                if (comboBox1.SelectedItem.ToString() == "RUBLE" &&
                    comboBox2.SelectedItem.ToString() == "MDL")
                {
                    double conver = i * 0.22;
                    label5.Text = "Suma obținuta: " + conver + "\t MDL";
                    label12.Text = "RUBLE";
                    label13.Text = "MDL";
                    label14.Text = "0";
                    label15.Text = "" + conver;
                }
                if (comboBox1.SelectedItem.ToString() == "RUBLE" &&
                    comboBox2.SelectedItem.ToString() == "EUR")
                {
                    double conver = i * 0.011;
                    label5.Text = "Suma obținuta: " + conver + "\t EUR";
                    label12.Text = "RUBLE";
                    label13.Text = "EUR";
                    label14.Text = "0";
                    label15.Text = "" + conver;
                }

                if (comboBox1.SelectedItem.ToString() == "RUBLE" &&
                   comboBox2.SelectedItem.ToString() == "USD")
                {
                    double conver = i * 0.013;
                    label5.Text = "Suma obținuta: " + conver + "\t USD";
                    label12.Text = "RUBLE";
                    label13.Text = "USD";
                    label14.Text = "0";
                    label15.Text = "" + conver;
                }

                if (comboBox1.SelectedItem.ToString() == "RUBLE" &&
                   comboBox2.SelectedItem.ToString() == "RON")
                {
                    double conver = i * 0.056;
                    label5.Text = "Suma obținuta: " + conver + "\t RON";
                    label12.Text = "RUBLE";
                    label13.Text = "RON";
                    label14.Text = "0";
                    label15.Text = "" + conver;
                }
                if (comboBox1.SelectedItem.ToString() == "RON" &&
                   comboBox2.SelectedItem.ToString() == "RUBLE")
                {
                    double conver = i * 17.76;
                    label5.Text = "Suma obținuta: " + conver + "\t RUBLE";
                    label12.Text = "RON";
                    label13.Text = "RUBLE";
                    label14.Text = "0";
                    label15.Text = "" + conver;
                }

                if (comboBox1.SelectedItem.ToString() == "EUR" &&
                   comboBox2.SelectedItem.ToString() == "RUBLE")
                {
                    double conver = i * 90.36;
                    label5.Text = "Suma obținuta: " + conver + "\t RUBLE";
                    label12.Text = "EUR";
                    label13.Text = "RUBLE";
                    label14.Text = "0";
                    label15.Text = "" + conver;
                }
                if (comboBox1.SelectedItem.ToString() == "USD" &&
                   comboBox2.SelectedItem.ToString() == "RUBLE")
                {
                    double conver = i * 76.25;
                    label5.Text = "Suma obținuta: " + conver + "\t RUBLE";
                    label12.Text = "USD";
                    label13.Text = "RUBLE";
                    label14.Text = "0";
                    label15.Text = "" + conver;
                }
            }
            else
            {
                label5.Text = " ati introdus nr negative";
                label5.BackColor = Color.Red;
                textBox1.BackColor = Color.Red;
            }





        }
    }
}
