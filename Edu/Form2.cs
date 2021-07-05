using System;
using System.Windows.Forms;

namespace Edu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void attendenceRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized;



        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            book hs = new book();


            hs.Show();
            this.Hide();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nazrastudent kh = new nazrastudent();
            kh.Show();
            this.Hide();
        }

        private void bookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            nazrabook nb = new nazrabook();
            nb.Show();
            this.Hide();
        }

        private void addExamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADDHIFZEXAM ab = new ADDHIFZEXAM();
            ab.Show();
            this.Hide();
        }

        private void examMarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewexam ex = new viewexam();
            ex.Show();
            this.Hide();
        }

        private void studentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            hafizstudent1 ns = new hafizstudent1();
            ns.Show();
            this.Hide();
        }

        private void addExamToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
