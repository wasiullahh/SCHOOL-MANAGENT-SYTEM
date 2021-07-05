using System;
using System.Windows.Forms;

namespace Edu
{
    public partial class book : Form2
    {
        public book()
        {
            InitializeComponent();
        }

        private void book_Load(object sender, EventArgs e)
        {
            loaddata();
            nametext.Enabled = false;
            dataGridView1.AutoGenerateColumns = false;

        }
        DataClasses abc = new DataClasses();
        private void button5_Click(object sender, EventArgs e)
        {
            edit = 1;
            nametext.Enabled = true;
        }

        private void loaddata()
        {
      

            var data = abc.gethafizbook();
       
            bookname.DataPropertyName = "Name";
            dataGridView1.DataSource = data;
           sno(dataGridView1, "Snogv");
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

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            edit = 2;
            nametext.Enabled = true;
        }
        int staffidd1;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                staffidd1 = Convert.ToInt32(row.Cells["Snogv"].Value.ToString());
                nametext.Text = row.Cells["bookname"].Value.ToString();
                //subjectdd.SelectedValue = row.Cells["Classidgvv"];
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            abc.ddeletehafizbooldelete(staffidd1);
            MessageBox.Show("Data Deleted Successfully");
            nametext.Text = "";
            loaddata();
            nametext.Enabled = false;
        }
        int edit;
        private void button8_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                abc.inserthafizbook(nametext.Text);
                MessageBox.Show("Data insert Successfully ");
                nametext.Text = "";
                loaddata();
                nametext.Enabled = false;

            }
            else if (edit == 2)
            {
                abc.updatehafizbook(staffidd1, nametext.Text);
                MessageBox.Show("Update data successfully");
                nametext.Text = "";
                loaddata();
                nametext.Enabled = false;

            }
        }
    }
}
