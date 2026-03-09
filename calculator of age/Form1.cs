using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_of_age
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            monthCalendar1.Hide();
            label2.Hide();
            button2.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            monthCalendar1.Show();
            button2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime data_nasterii =
monthCalendar1.SelectionRange.Start;
            var azi = DateTime.Today;
            int varsta = azi.Year - data_nasterii.Year;
            int nrluni = azi.Month - data_nasterii.Month;
            if (nrluni < 0)
                nrluni = 12 - data_nasterii.Month + azi.Month;
            if (data_nasterii.AddYears(varsta) > azi)
                varsta--;
            label2.Text = "Varsta in ani este :" +
            varsta.ToString() + " ani " + nrluni.ToString();
            label2.Show();
        
    }
    }
}
