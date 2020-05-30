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
    public partial class Add_appointment : Form
    {
        private bool u = false;
        private int v1;
        private int v2;
        private DateTime v3;
        private string v4;

        public Add_appointment()
        {
            InitializeComponent();
            u = false;
        }

        public Add_appointment(int v1, int v2, DateTime v3, string v4)
        {
            InitializeComponent();
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            u = true;
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

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

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Manage_appointment ma = new Manage_appointment();
            Close();
            ma.Show();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Appointment a = new Appointment();
            a.P_id = Convert.ToInt32(textBox1.Text.ToString());
            a.Date = dateTimePicker1.Value;
            a.time = comboBox1.Text.ToString();
            if(login.Text == "UPDATE")
            {
                a.A_id = v1;
                a.updateAppointment(this);
            }
            else
                a.addAppointment(this);

        }

        private void Add_appointment_Load(object sender, EventArgs e)
        {
            if(u)
            {
                textBox1.Text = v2.ToString();
                dateTimePicker1.Value = v3;
                comboBox1.SelectedItem = v4;
                label6.Text = "Update Appointment Details";
                login.Text = "UPDATE";
            }
        }
    }
}
