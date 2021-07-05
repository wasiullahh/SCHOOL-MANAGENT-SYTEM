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
    public partial class nazrabook : Form2
    {
        public nazrabook()
        {
            InitializeComponent();
        }

        private void nazrabook_Load(object sender, EventArgs e)
        {
            loaddata();
            nametext.Enabled = false;
            dataGridView1.AutoGenerateColumns = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            edit = 1;
            nametext.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            edit = 2;
            nametext.Enabled = true;
        }
        private void loaddata()
        {
            nametext.Enabled = true;

            var data = abc.getnazrabook();
            dataGridView1.AutoGenerateColumns = false;
            roleidgv.DataPropertyName = "id";
            bookname.DataPropertyName = "Name";
            dataGridView1.DataSource = data;
            book.sno(dataGridView1, "Snogv");
        }
        public static void sno(DataGridView gv, string colname)
        {
            int count = 0;
            foreach (DataGridViewRow row in gv.Rows)
            {
                count++;
                row.Cells[colname].Value = count;
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            abc.ddeletenazrabooldelete(staffidd1);
            MessageBox.Show("Data Deleted Successfully");
            nametext.Text = "";
            loaddata();
            nametext.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                abc.insertnazrabook(nametext.Text);
                MessageBox.Show("Data insert Successfully ");
                nametext.Text = "";
                loaddata();
                nametext.Enabled = false;

            }
            else if (edit == 2)
            {
                abc.updatenazrabook(staffidd1, nametext.Text);
                MessageBox.Show("Update data successfully");
                nametext.Text = "";
                loaddata();
                nametext.Enabled = false;

            }
        }
        int staffidd1;
        int edit;
        DataClasses abc = new DataClasses();
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                staffidd1 = Convert.ToInt32(row.Cells["roleidgv"].Value.ToString());
                nametext.Text = row.Cells["bookname"].Value.ToString();
                //subjectdd.SelectedValue = row.Cells["Classidgvv"];
            }
        }
    }
}
