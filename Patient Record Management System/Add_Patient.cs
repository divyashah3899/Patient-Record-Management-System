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
    public partial class Add_Patient : Form
    {
        private bool u = false;
        private int v1;
        private string v2;
        private string v3;
        private string v4;
        private string v5;

        public Form back { get; set; }
        public Add_Patient(Form form)
        {
            InitializeComponent();
            back = form;
            u = false;
        }
    

        public Add_Patient(int v1, string v2, string v3, string v4, string v5)
        {
            InitializeComponent();
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
            u = true;
        }

        public Add_Patient()
        {
            InitializeComponent();
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            Patient p = new Patient();
            p.name = textBox1.Text.ToString();
            p.address = textBox3.Text.ToString();
            p.contactno = textBox2.Text.ToString();
            p.email = textBox4.Text.ToString();
            if (login.Text == "SAVE")
            {
                p.addPatient();
            }
            else
            {
                p.id = v1;
                p.updatePatient();
            }
            Manage_patient mp = new Manage_patient();
            this.Close();
            mp.Show();

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Manage_patient mp = new Manage_patient();
            this.Close();
            mp.Show();
        }

        private void Add_Patient_Load(object sender, EventArgs e)
        {
            if(u)
            {
                textBox1.Text = v2;
                textBox2.Text = v3;
                textBox3.Text = v4;
                textBox4.Text = v5;
                label6.Text = "Update Patient Details";
                login.Text = "UPDATE";
            }
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Receptionist_Dashboard rd = new Receptionist_Dashboard();
            this.Close();
            rd.Show();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logging Out,Receptionist...");
            Login_As la = new Login_As();
            this.Close();
            la.Show();
        }
    }
}
