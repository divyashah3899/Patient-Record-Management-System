using Patient_Record_Management_System.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patient_Record_Management_System
{
    public partial class Manage_Medicine : Form
    {
        public Manage_Medicine()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                Medicine m = new Medicine();
                m.M_Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                m.deleteMedicine();
                Manage_Medicine mp = new Manage_Medicine();
                this.Close();
                mp.Show();
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Manage_Medicine_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pRMSDataSet10.Medicine' table. You can move, or remove it, as needed.
            this.medicineTableAdapter.Fill(this.pRMSDataSet10.Medicine);

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Pharmacist_dashboard pd = new Pharmacist_dashboard();
            this.Close();
            pd.Show();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Pharmacist_dashboard pd = new Pharmacist_dashboard();
            this.Close();
            pd.Show();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logging Out,Pharmacist...");
            Login_As la = new Login_As();
            this.Close();
            la.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Add_Medicine ad = new Add_Medicine();
            this.Close();
            ad.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                Add_Medicine ad = new Add_Medicine(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[2].Value.ToString(),Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value),Convert.ToDateTime(dataGridView1.CurrentRow.Cells[4].Value),Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value), Convert.ToInt32(dataGridView1.CurrentRow.Cells[6].Value));
                Close();
                ad.Show();
            }
        }
    }
}
