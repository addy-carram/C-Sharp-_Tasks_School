using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private int nr = 0;
        private void CreateChild()
        {
            // Creăm o forma child.
            Form f = new Form();
            nr++;

            // Textul din bara de titlu
            f.Text = "Documentul " + nr;

            // Forma f devine document child
            // this este referinţă la forma container
            f.MdiParent = this;

            // Afişează forma child
            f.Show();
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Italic);
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Red;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Blue;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Green;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Black;
        }

        private void clearTextboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear(); //sterge textul afisat in caseta
            richTextBox1.Visible = false;
        }

        private void redToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Red;
        }

        private void blueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Blue;
        }

        private void greenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Green;
        }

        private void blackToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Black;
        }

        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont= new Font("Times New Roman", richTextBox1.Font.Size);
        }

        private void courierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font("Courier", richTextBox1.Font.Size);
        }

        private void comicSansSerifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font("Comic Sans Serif", richTextBox1.Font.Size);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

            richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 16);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 18);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 20);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 22);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 30);
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 40);
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 50);
        }

        private void centerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void justifiedToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void colorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog.Color;
            }
        }

        private void minimalizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad");
        }
        private void CreateNewDocument(string text ="",string filePath="")
        {
            Form f = new Form();
            nr++;
            f.Text = "Documentul " + nr;
            RichTextBox rtb = new RichTextBox();
            rtb.Dock = DockStyle.Fill;
            rtb.Text = text;
            f.Controls.Add(rtb);
            f.MdiParent = this;
            f.Show();   
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CreateNewDocument();
        }
    }
}
