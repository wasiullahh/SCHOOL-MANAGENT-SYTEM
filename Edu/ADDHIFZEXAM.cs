using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edu
{
    public partial class ADDHIFZEXAM : Form2
    {
        public ADDHIFZEXAM()
        {
            InitializeComponent();
        }

        private void ADDHIFZEXAM_Load(object sender, EventArgs e)
        {
            panel3.Enabled = false;


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel3.Enabled = true;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel3.Enabled = false;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel3.Enabled = false;

        }
    }
}
