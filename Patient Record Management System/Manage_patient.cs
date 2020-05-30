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
    public partial class Manage_patient : Form
    {
        public Form back { get; set; }
        public Manage_patient(Form form)
        {
            InitializeComponent();
            back = form;
        }
        public Manage_patient()
        {
            InitializeComponent();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Receptionist_Dashboard rd = new Receptionist_Dashboard();
            Close();
            rd.Show();
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

        private void Manage_patient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pRMSDataSet12.Patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter3.Fill(this.pRMSDataSet12.Patients);
            // TODO: This line of code loads data into the 'pRMSDataSet2.Patients' table. You can move, or remove it, as needed.
            

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Add_Patient ad = new Add_Patient(this);
            Close();
            ad.Show();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                Add_Patient ad = new Add_Patient(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[2].Value.ToString(), dataGridView1.CurrentRow.Cells[3].Value.ToString(), dataGridView1.CurrentRow.Cells[4].Value.ToString());
                Close();
                ad.Show();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                Patient p = new Patient();
                p.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                p.deletePatient();
                Manage_patient mp = new Manage_patient();
                this.Close();
                mp.Show();
            }

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("CONVERT(P_Id,System.String) like '{0}%' OR Name like '{0}%' OR ContactNo like '{0}%' OR Address like '{0}%' OR EmailId like '{0}%'",textBox1.Text.ToString()); ;
            dataGridView1.DataSource = bs;
        }
    }
}
