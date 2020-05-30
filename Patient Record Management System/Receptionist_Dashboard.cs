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
    public partial class Receptionist_Dashboard : Form
    {
        public Receptionist_Dashboard()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Manage_patient mp = new Manage_patient(this);
            Hide();
            mp.Show();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logging Out,Receptionist...");
            Login_As la = new Login_As();
            this.Close();
            la.Show();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Manage_appointment ma = new Manage_appointment(this);
            Hide();
            ma.Show();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Receptionist_Dashboard_Load(object sender, EventArgs e)
        {
            Appointment a = new Appointment();
            label2.Text = a.todayAppointment().ToString();
            label3.Text = a.totalIncome().ToString();
        }
    }
}
