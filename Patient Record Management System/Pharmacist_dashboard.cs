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
    public partial class Pharmacist_dashboard : Form
    {
        public Pharmacist_dashboard()
        {
            InitializeComponent();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logging Out,Pharmacist...");
            Login_As la = new Login_As();
            this.Close();
            la.Show();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Manage_Medicine mm = new Manage_Medicine();
            this.Close();
            mm.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            All_Patient_List al = new All_Patient_List();
            al.Show();
        }

        private void Pharmacist_dashboard_Load(object sender, EventArgs e)
        {
            Medicine m = new Medicine();
            label3.Text = m.totalIncome().ToString(); ;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Bill_generate bg = new Bill_generate();
            this.Close();
            bg.Show();
        }
    }
}
