using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStrip___96
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OgrenciEkle ogrenciEkle = new OgrenciEkle();
            ogrenciEkle.ShowDialog();
        }

        private void kalınToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
        }

        private void ptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font("Arial Back", 12);
        }

        private void ptToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font("Arial Back", 15);
        }

        private void ptToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font("Arial Back", 20);
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
