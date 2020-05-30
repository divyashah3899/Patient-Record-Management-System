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
    public partial class doctorlogin : Form
    {
        public Form back { get; set; }
        public doctorlogin(Form form)
        {
            InitializeComponent();
            back = form;
        }

        private void Doctorlogin_Load(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            password.Clear();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            var user = textBox1.Text;
            var pass = password.Text;
            if (user == "Doctor" && pass == "123456")
            {
                MessageBox.Show("Successfully logged in");
                Doctor_Dashboard dd = new Doctor_Dashboard();
                this.Close();
                dd.Show();
            }
            else
            {
                MessageBox.Show("Invalid credentials");
            }
        }

        private void BackLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            back.Show();
            this.Close();
                
        }
    }
}
