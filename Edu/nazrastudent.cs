using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Edu
{
    public partial class nazrastudent : Form2
    {
        public nazrastudent()
        {
            InitializeComponent();
        }

        private void nazra_Load(object sender, EventArgs e)
        {
            panel3.Enabled = false;
            loadclass();
        }

        private void loadclass()
        {


            var l2 = (from a in abc.hafizbooks select new { a.id, a.hafizbookdata }).ToList();
            l2.Insert(0, new { id = 0, hafizbookdata = "Select" });
            comboBox1.DataSource = l2;
            comboBox1.ValueMember = "id";
            comboBox1.DisplayMember = "hafizbookdata";



        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 ab = new Form2();
            ab.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            adddstudent ab = new adddstudent();
            ab.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        DataClasses abc = new DataClasses();

        private void button8_Click(object sender, EventArgs e)
        {
            panel3.Enabled = true;
            edit = 1;

        }
        DataClasses d = new DataClasses();
        int edit;
        private void button4_Click_1(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                abc.inssertnazrastd(nametext.Text, Fathertext.Text, Convert.ToInt32(mobileext.Text),
                    (comboBox1.Text), Convert.ToInt32(nictext.Text),
                    Convert.ToByte(nationdd.SelectedIndex.ToString()),
               dateTimePicker1.Value, datetext.Value, addresstext.Text, textBox2.Text); ; ;
                MessageBox.Show("Data Inserted Sucessfully ");
                loaddata();
                panel3.Enabled = false;
                nametext.Text = "";
                Fathertext.Text = "";
                mobileext.Text = "";
                // phonetext2.Text = "";
                nictext.Text = "";
                nationdd.SelectedIndex = -1;
                addresstext.Text = "";
                textBox2.Text = "";

            }
            else if (edit == 2)
            {
                abc.upddatetnazrastd(staffidd1, nametext.Text, Fathertext.Text, Convert.ToInt32(mobileext.Text), comboBox1.Text, Convert.ToInt32(nictext.Text)
           , Convert.ToByte(nationdd.SelectedIndex), dateTimePicker1.Value, datetext.Value, addresstext.Text, textBox2.Text);
                MessageBox.Show("Data Updated Sucessfully ");
                loaddata();
                panel3.Enabled = false;
                nametext.Text = "";
                Fathertext.Text = "";
                mobileext.Text = "";
                ///phonetext2.Text = "";
                nictext.Text = "";
                nationdd.SelectedIndex = -1;
                addresstext.Text = "";
                textBox2.Text = "";

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            edit = 2;
            panel3.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Are you you want to delete", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                abc.ddeletenazrastuddentdelete(staffidd1);
                MessageBox.Show("Data has been deleted");
                loaddata();

            }
        }

        private void nametext_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        int staffidd1;
        private void loaddata()
        {
            nametext.Enabled = true;

            var data = abc.getnazrastudent();
            dataGridView1.AutoGenerateColumns = false;
            roldidgv.DataPropertyName = "id";
            namegv.DataPropertyName = "Name";
            fathergv.DataPropertyName = "fathername";
            Mobilegv.DataPropertyName = "mobileno";
            admissionbk.DataPropertyName = "admissionno";
            nationgv.DataPropertyName = "nation";
            doagv.DataPropertyName = "doa";
            dobgv.DataPropertyName = "dob";
            paddress.DataPropertyName = "paddress";
            address.DataPropertyName = "adddress";
            cnicgv.DataPropertyName = "cnic";

            dataGridView1.DataSource = data;
            book.sno(dataGridView1, "idgv");
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                staffidd1 = Convert.ToInt32(row.Cells["idgv"].Value.ToString());
                nametext.Text = row.Cells["namegv"].Value.ToString();

                Fathertext.Text = row.Cells["fathergv"].Value.ToString();
                mobileext.Text = row.Cells["Mobilegv"].Value.ToString();
                nictext.Text = row.Cells["cnicgv"].Value.ToString();
                addresstext.Text = row.Cells["address"].Value.ToString();
                textBox2.Text = row.Cells["paddress"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["doagv"].Value);
                datetext.Value = Convert.ToDateTime(row.Cells["dobgv"].Value);
                nationdd.SelectedItem = row.Cells["nationgv"].Value;
                comboBox1.SelectedItem = row.Cells["admissionbk"].Value;


            }
        }
    }
}
