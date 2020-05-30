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
    public partial class Manage_appointment : Form
    {
        public Form back { get; set; }
        public Manage_appointment(Form form)
        {
            InitializeComponent();
            back = form;
        }
        public Manage_appointment()

        {
            InitializeComponent();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            back.Show();
            Close();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logging Out,Receptionist...");
            Login_As la = new Login_As();
            this.Close();
            la.Show();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Receptionist_Dashboard rd = new Receptionist_Dashboard();
            this.Close();
            rd.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Add_appointment ad = new Add_appointment();
            Close();
            ad.Show();
        }

        private void Manage_appointment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pRMSDataSet3.Appointment' table. You can move, or remove it, as needed.
            this.appointmentTableAdapter.Fill(this.pRMSDataSet3.Appointment);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                Add_appointment ad = new Add_appointment(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value), Convert.ToDateTime(dataGridView1.CurrentRow.Cells[2].Value), dataGridView1.CurrentRow.Cells[3].Value.ToString());
                Close();
                ad.Show();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                Appointment a = new Appointment();
                a.A_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                a.deleteAppointment();
                Manage_appointment mp = new Manage_appointment();
                this.Close();
                mp.Show();
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("CONVERT(A_Id,System.String) like '{0}%' OR CONVERT(P_Id,System.String) like '{0}%' OR CONVERT(Date,System.String) like '{0}%' OR Time like '{0}%'", textBox1.Text.ToString()); ;
            dataGridView1.DataSource = bs;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                Appointment a = new Appointment(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value), Convert.ToDateTime(dataGridView1.CurrentRow.Cells[2].Value), dataGridView1.CurrentRow.Cells[3].Value.ToString());
                a.generateBill();
            }
        }
    }
}
