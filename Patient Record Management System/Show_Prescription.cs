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
    public partial class Show_Prescription : Form
    {
        public int pid { get; set; }
        public Show_Prescription(int id)
        {
            InitializeComponent();
            pid = id;
        }

        private void Show_Prescription_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pRMSDataSet7.Prescription' table. You can move, or remove it, as needed.
            this.prescriptionTableAdapter.Fill(this.pRMSDataSet7.Prescription);
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("CONVERT(P_Id,System.String) like '{0}%'", pid.ToString()); ;
            dataGridView1.DataSource = bs;

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            All_Patient_List all = new All_Patient_List();
            this.Close();
            all.Show();
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
    }
}
