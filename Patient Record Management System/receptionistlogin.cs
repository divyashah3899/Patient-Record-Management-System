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
    public partial class receptionistlogin : Form
    {
        public Form back { get; set; }
        public receptionistlogin(Form form)
        {
            InitializeComponent();
            back = form;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            var user = textBox1.Text;
            var pass = password.Text;
            if (user == "Receptionist" && pass == "123456")
            {
                MessageBox.Show("Successfully logged in");
                Receptionist_Dashboard rd = new Receptionist_Dashboard();
                this.Close();
                rd.Show();
            }
            else
            {
                MessageBox.Show("Invalid credentials");
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            password.Clear();
        }

        private void BackLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            back.Show();
            this.Close();
        }
    }
}
