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
    public partial class Add_Medicine : Form
    {
        private int v1;
        private string v2;
        private string v3;
        private DateTime dateTime1;
        private DateTime dateTime2;
        private int v4;
        private int v5;
        private bool u = false;

        public Add_Medicine()
        {
            InitializeComponent();
            u = false;
        }

        public Add_Medicine(int v1, string v2, string v3, DateTime dateTime1, DateTime dateTime2, int v4, int v5)
        {
            InitializeComponent();
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.dateTime1 = dateTime1;
            this.dateTime2 = dateTime2;
            this.v4 = v4;
            this.v5 = v5;
            u = true;
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Manage_Medicine mm = new Manage_Medicine();
            this.Close();
            mm.Show();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Pharmacist_dashboard pd = new Pharmacist_dashboard();
            this.Close();
            pd.Show();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logging Out,Pharmacist...");
            Login_As la = new Login_As();
            this.Close();
            la.Show();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Medicine m = new Medicine();
            m.Name = textBox1.Text.ToString();
            m.Company = textBox2.Text.ToString();
            m.M_Date = dateTimePicker1.Value;
            m.E_Date = dateTimePicker2.Value;
            m.Price = Convert.ToInt32(textBox3.Text.ToString());
            m.Unit = Convert.ToInt32(textBox4.Text.ToString());
            if(login.Text == "SAVE")
                m.addMedicine();
            else
            {
                m.M_Id = v1;
                m.updateMedicine();
            }
            Manage_Medicine mm = new Manage_Medicine();
            this.Close();
            mm.Show();
        }

        private void Add_Medicine_Load(object sender, EventArgs e)
        {
            if(u)
            {
                textBox1.Text = v2;
                textBox2.Text = v3;
                dateTimePicker1.Value = dateTime1;
                dateTimePicker2.Value = dateTime2;
                textBox3.Text = v4.ToString();
                textBox4.Text = v5.ToString();
                login.Text = "UPDATE";
            }
        }
    }
}
