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
    public partial class Prescribe_Medicine : Form
    {
        public int pid { get; set; }
        public Prescribe_Medicine(int id)
        {
            InitializeComponent();
            pid = id;
        }

        private void Prescribe_Medicine_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pRMSDataSet9.Prescription' table. You can move, or remove it, as needed.
            this.prescriptionTableAdapter.Fill(this.pRMSDataSet9.Prescription);
            // TODO: This line of code loads data into the 'pRMSDataSet8.Doctor_Medicine' table. You can move, or remove it, as needed.
            this.doctor_MedicineTableAdapter.Fill(this.pRMSDataSet8.Doctor_Medicine);
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("CONVERT(P_Id,System.String) like '{0}%'", pid.ToString()); ;
            dataGridView1.DataSource = bs;
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Today_Appointment_List tl = new Today_Appointment_List();
            this.Close();
            tl.Show();
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

        private void Button1_Click(object sender, EventArgs e)
        {
            Medicine m = new Medicine();
            m.Name = comboBox1.Text.ToString();
            m.Time = comboBox2.Text.ToString();
            m.Days = Convert.ToInt32(textBox1.Text.ToString());
            m.Remark = textBox2.Text.ToString();
            if (checkedListBox1.GetItemChecked(0))
                m.Morning = "Yes";
            else
                m.Morning = "No";
            if (checkedListBox1.GetItemChecked(1))
                m.Afternoon = "Yes";
            else
                m.Afternoon = "No";
            if (checkedListBox1.GetItemChecked(2))
                m.Evening = "Yes";
            else
                m.Evening = "No";
            if (checkedListBox1.GetItemChecked(3))
                m.Night = "Yes";
            else
                m.Night = "No";
            m.P_Id = pid;
            m.addPrescription();
            Prescribe_Medicine pm = new Prescribe_Medicine(pid);
            this.Close();
            pm.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                Medicine m = new Medicine();
                m.Prescribe_Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                m.deletePrescription();
                Prescribe_Medicine mp = new Prescribe_Medicine(pid);
                this.Close();
                mp.Show();
            }
        }
    }
}
