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
    public partial class Bill_generate : Form
    {
        public Bill_generate()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Medicine m = new Medicine();
            m.generateBill();
            Pharmacist_dashboard pd = new Pharmacist_dashboard();
            this.Close();
            pd.Show();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Medicine m = new Medicine();
            m.P_Id = Convert.ToInt32(textBox1.Text.ToString());
            m.Name = comboBox1.Text.ToString();
            m.Unit = Convert.ToInt32(textBox2.Text.ToString());
            m.addToBill(this);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Bill_generate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pRMSDataSet11.Bill' table. You can move, or remove it, as needed.
            this.billTableAdapter.Fill(this.pRMSDataSet11.Bill);
            // TODO: This line of code loads data into the 'pRMSDataSet6.Medicine' table. You can move, or remove it, as needed.
            this.medicineTableAdapter.Fill(this.pRMSDataSet6.Medicine);

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Pharmacist_dashboard pd = new Pharmacist_dashboard();
            this.Close();
            pd.Show();
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
    }
}
