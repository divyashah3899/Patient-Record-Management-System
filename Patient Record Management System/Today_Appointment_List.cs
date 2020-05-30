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
    public partial class Today_Appointment_List : Form
    {
        public Today_Appointment_List()
        {
            InitializeComponent();
        }

        private void Today_Appointment_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pRMSDataSet4.Appointment' table. You can move, or remove it, as needed.
            this.appointmentTableAdapter.Fill(this.pRMSDataSet4.Appointment);
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("CONVERT(Date,System.String) like '{0}%'", DateTime.Today.ToString()); ;
            dataGridView1.DataSource = bs;

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logging Out,Doctor...");
            Login_As la = new Login_As();
            this.Close();
            la.Show();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Doctor_Dashboard dd = new Doctor_Dashboard();
            this.Close();
            dd.Show();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Doctor_Dashboard dd = new Doctor_Dashboard();
            this.Close();
            dd.Show();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("CONVERT(A_Id,System.String) like '{0}%' OR CONVERT(P_Id,System.String) like '{0}%' OR CONVERT(Date,System.String) like '{0}%' OR Time like '{0}%'", textBox1.Text.ToString()); ;
            dataGridView1.DataSource = bs;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                Prescribe_Medicine sp = new Prescribe_Medicine(Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value));
                this.Hide();
                sp.Show();
            }
            else
            {
                MessageBox.Show("Select Any Patient to Proceed.");
            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
