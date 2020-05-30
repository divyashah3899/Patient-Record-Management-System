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
    public partial class Doctor_Dashboard : Form
    {
        public Doctor_Dashboard()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Today_Appointment_List tl = new Today_Appointment_List();
            Close();
            tl.Show();

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void Doctor_Dashboard_Load(object sender, EventArgs e)
        {
            Appointment a = new Appointment();
            label3.Text = a.totalIncome().ToString();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logging Out,Doctor...");
            Login_As la = new Login_As();
            this.Close();
            la.Show();
        }

        private void PictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            All_Patient_List al = new All_Patient_List();
            this.Close();
            al.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Doctor_Add_Medicine da = new Doctor_Add_Medicine();
            this.Close();
            da.Show();
        }
    }
}
