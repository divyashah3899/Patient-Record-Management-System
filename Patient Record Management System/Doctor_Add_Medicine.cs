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
    public partial class Doctor_Add_Medicine : Form
    {
        public Doctor_Add_Medicine()
        {
            InitializeComponent();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

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

        private void Login_Click(object sender, EventArgs e)
        {
            Medicine m = new Medicine();
            m.Name = textBox1.Text.ToString();
            m.Company = textBox2.Text.ToString();
            m.Description = textBox3.Text.ToString();
            m.addDocMedicine();
            MessageBox.Show("Added Successfully...");
        }
    }
}
