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
    public partial class All_Patient_List : Form
    {
        public All_Patient_List()
        {
            InitializeComponent();
        }

        private void All_Patient_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pRMSDataSet13.Patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter1.Fill(this.pRMSDataSet13.Patients);
            // TODO: This line of code loads data into the 'pRMSDataSet5.Patients' table. You can move, or remove it, as needed.


        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("CONVERT(P_Id,System.String) like '{0}%' OR Name like '{0}%' OR ContactNo like '{0}%' OR Address like '{0}%' OR EmailId like '{0}%'", textBox1.Text.ToString()); ;
            dataGridView1.DataSource = bs;
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Doctor_Dashboard dd = new Doctor_Dashboard();
            this.Close();
            dd.Show();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Doctor_Dashboard dd = new Doctor_Dashboard();
            this.Close();
            dd.Show();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logging Out,Doctor...");
            Login_As la = new Login_As();
            this.Close();
            la.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                Show_Prescription sp = new Show_Prescription(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                this.Hide();
                sp.Show();
            }
            else
            {
                MessageBox.Show("Select Any Patient to Proceed.");
            }
        }
    }
}
