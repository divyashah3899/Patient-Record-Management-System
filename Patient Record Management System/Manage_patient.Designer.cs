namespace Patient_Record_Management_System
{
    partial class Manage_patient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage_patient));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pRMSDataSet2 = new Patient_Record_Management_System.PRMSDataSet2();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pRMSDataSet = new Patient_Record_Management_System.PRMSDataSet();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientsTableAdapter = new Patient_Record_Management_System.PRMSDataSetTableAdapters.PatientsTableAdapter();
            this.pRMSDataSet1 = new Patient_Record_Management_System.PRMSDataSet1();
            this.patientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.patientsTableAdapter1 = new Patient_Record_Management_System.PRMSDataSet1TableAdapters.PatientsTableAdapter();
            this.patientsTableAdapter2 = new Patient_Record_Management_System.PRMSDataSet2TableAdapters.PatientsTableAdapter();
            this.pRMSDataSet12 = new Patient_Record_Management_System.PRMSDataSet12();
            this.patientsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.patientsTableAdapter3 = new Patient_Record_Management_System.PRMSDataSet12TableAdapters.PatientsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRMSDataSet2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRMSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRMSDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.contactNoDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.emailIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.patientsBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(12, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(820, 338);
            this.dataGridView1.TabIndex = 5;
            // 
            // pIdDataGridViewTextBoxColumn
            // 
            this.pIdDataGridViewTextBoxColumn.DataPropertyName = "P_Id";
            this.pIdDataGridViewTextBoxColumn.HeaderText = "P_Id";
            this.pIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pIdDataGridViewTextBoxColumn.Name = "pIdDataGridViewTextBoxColumn";
            this.pIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.pIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // contactNoDataGridViewTextBoxColumn
            // 
            this.contactNoDataGridViewTextBoxColumn.DataPropertyName = "ContactNo";
            this.contactNoDataGridViewTextBoxColumn.HeaderText = "ContactNo";
            this.contactNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactNoDataGridViewTextBoxColumn.Name = "contactNoDataGridViewTextBoxColumn";
            this.contactNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailIdDataGridViewTextBoxColumn
            // 
            this.emailIdDataGridViewTextBoxColumn.DataPropertyName = "EmailId";
            this.emailIdDataGridViewTextBoxColumn.HeaderText = "EmailId";
            this.emailIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailIdDataGridViewTextBoxColumn.Name = "emailIdDataGridViewTextBoxColumn";
            this.emailIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // patientsBindingSource2
            // 
            this.patientsBindingSource2.DataMember = "Patients";
            this.patientsBindingSource2.DataSource = this.pRMSDataSet2;
            // 
            // pRMSDataSet2
            // 
            this.pRMSDataSet2.DataSetName = "PRMSDataSet2";
            this.pRMSDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 90);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 42);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.Location = new System.Drawing.Point(318, 87);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(146, 45);
            this.button6.TabIndex = 14;
            this.button6.Text = "SEARCH";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(686, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 45);
            this.button1.TabIndex = 15;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(265, 503);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 45);
            this.button2.TabIndex = 16;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(438, 503);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 45);
            this.button3.TabIndex = 17;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 61);
            this.panel1.TabIndex = 18;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(669, 15);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(721, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 35);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Patient Record Management";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(776, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 35);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // pRMSDataSet
            // 
            this.pRMSDataSet.DataSetName = "PRMSDataSet";
            this.pRMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "Patients";
            this.patientsBindingSource.DataSource = this.pRMSDataSet;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // pRMSDataSet1
            // 
            this.pRMSDataSet1.DataSetName = "PRMSDataSet1";
            this.pRMSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientsBindingSource1
            // 
            this.patientsBindingSource1.DataMember = "Patients";
            this.patientsBindingSource1.DataSource = this.pRMSDataSet1;
            // 
            // patientsTableAdapter1
            // 
            this.patientsTableAdapter1.ClearBeforeFill = true;
            // 
            // patientsTableAdapter2
            // 
            this.patientsTableAdapter2.ClearBeforeFill = true;
            // 
            // pRMSDataSet12
            // 
            this.pRMSDataSet12.DataSetName = "PRMSDataSet12";
            this.pRMSDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientsBindingSource3
            // 
            this.patientsBindingSource3.DataMember = "Patients";
            this.patientsBindingSource3.DataSource = this.pRMSDataSet12;
            // 
            // patientsTableAdapter3
            // 
            this.patientsTableAdapter3.ClearBeforeFill = true;
            // 
            // Manage_patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(844, 560);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Manage_patient";
            this.Text = "Manage_patient";
            this.Load += new System.EventHandler(this.Manage_patient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRMSDataSet2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRMSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRMSDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private PRMSDataSet pRMSDataSet;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private PRMSDataSetTableAdapters.PatientsTableAdapter patientsTableAdapter;
        private PRMSDataSet1 pRMSDataSet1;
        private System.Windows.Forms.BindingSource patientsBindingSource1;
        private PRMSDataSet1TableAdapters.PatientsTableAdapter patientsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailIdDataGridViewTextBoxColumn;
        private PRMSDataSet2 pRMSDataSet2;
        private System.Windows.Forms.BindingSource patientsBindingSource2;
        private PRMSDataSet2TableAdapters.PatientsTableAdapter patientsTableAdapter2;
        private PRMSDataSet12 pRMSDataSet12;
        private System.Windows.Forms.BindingSource patientsBindingSource3;
        private PRMSDataSet12TableAdapters.PatientsTableAdapter patientsTableAdapter3;
    }
}