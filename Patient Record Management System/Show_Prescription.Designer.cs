namespace Patient_Record_Management_System
{
    partial class Show_Prescription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Show_Prescription));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pRMSDataSet7 = new Patient_Record_Management_System.PRMSDataSet7();
            this.prescriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prescriptionTableAdapter = new Patient_Record_Management_System.PRMSDataSet7TableAdapters.PrescriptionTableAdapter();
            this.prescribeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.morningDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.afternoonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eveningDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRMSDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 21;
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prescribeIdDataGridViewTextBoxColumn,
            this.pIdDataGridViewTextBoxColumn,
            this.medicineNameDataGridViewTextBoxColumn,
            this.morningDataGridViewTextBoxColumn,
            this.afternoonDataGridViewTextBoxColumn,
            this.eveningDataGridViewTextBoxColumn,
            this.nightDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.daysDataGridViewTextBoxColumn,
            this.remarkDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.prescriptionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(820, 338);
            this.dataGridView1.TabIndex = 28;
            // 
            // pRMSDataSet7
            // 
            this.pRMSDataSet7.DataSetName = "PRMSDataSet7";
            this.pRMSDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prescriptionBindingSource
            // 
            this.prescriptionBindingSource.DataMember = "Prescription";
            this.prescriptionBindingSource.DataSource = this.pRMSDataSet7;
            // 
            // prescriptionTableAdapter
            // 
            this.prescriptionTableAdapter.ClearBeforeFill = true;
            // 
            // prescribeIdDataGridViewTextBoxColumn
            // 
            this.prescribeIdDataGridViewTextBoxColumn.DataPropertyName = "Prescribe_Id";
            this.prescribeIdDataGridViewTextBoxColumn.HeaderText = "Prescribe_Id";
            this.prescribeIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prescribeIdDataGridViewTextBoxColumn.Name = "prescribeIdDataGridViewTextBoxColumn";
            this.prescribeIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.prescribeIdDataGridViewTextBoxColumn.Visible = false;
            this.prescribeIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // pIdDataGridViewTextBoxColumn
            // 
            this.pIdDataGridViewTextBoxColumn.DataPropertyName = "P_Id";
            this.pIdDataGridViewTextBoxColumn.HeaderText = "P_Id";
            this.pIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pIdDataGridViewTextBoxColumn.Name = "pIdDataGridViewTextBoxColumn";
            this.pIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.pIdDataGridViewTextBoxColumn.Visible = false;
            this.pIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // medicineNameDataGridViewTextBoxColumn
            // 
            this.medicineNameDataGridViewTextBoxColumn.DataPropertyName = "Medicine_Name";
            this.medicineNameDataGridViewTextBoxColumn.HeaderText = "Medicine_Name";
            this.medicineNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.medicineNameDataGridViewTextBoxColumn.Name = "medicineNameDataGridViewTextBoxColumn";
            this.medicineNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.medicineNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // morningDataGridViewTextBoxColumn
            // 
            this.morningDataGridViewTextBoxColumn.DataPropertyName = "Morning";
            this.morningDataGridViewTextBoxColumn.HeaderText = "Morning";
            this.morningDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.morningDataGridViewTextBoxColumn.Name = "morningDataGridViewTextBoxColumn";
            this.morningDataGridViewTextBoxColumn.ReadOnly = true;
            this.morningDataGridViewTextBoxColumn.Width = 125;
            // 
            // afternoonDataGridViewTextBoxColumn
            // 
            this.afternoonDataGridViewTextBoxColumn.DataPropertyName = "Afternoon";
            this.afternoonDataGridViewTextBoxColumn.HeaderText = "Afternoon";
            this.afternoonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.afternoonDataGridViewTextBoxColumn.Name = "afternoonDataGridViewTextBoxColumn";
            this.afternoonDataGridViewTextBoxColumn.ReadOnly = true;
            this.afternoonDataGridViewTextBoxColumn.Width = 125;
            // 
            // eveningDataGridViewTextBoxColumn
            // 
            this.eveningDataGridViewTextBoxColumn.DataPropertyName = "Evening";
            this.eveningDataGridViewTextBoxColumn.HeaderText = "Evening";
            this.eveningDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eveningDataGridViewTextBoxColumn.Name = "eveningDataGridViewTextBoxColumn";
            this.eveningDataGridViewTextBoxColumn.ReadOnly = true;
            this.eveningDataGridViewTextBoxColumn.Width = 125;
            // 
            // nightDataGridViewTextBoxColumn
            // 
            this.nightDataGridViewTextBoxColumn.DataPropertyName = "Night";
            this.nightDataGridViewTextBoxColumn.HeaderText = "Night";
            this.nightDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nightDataGridViewTextBoxColumn.Name = "nightDataGridViewTextBoxColumn";
            this.nightDataGridViewTextBoxColumn.ReadOnly = true;
            this.nightDataGridViewTextBoxColumn.Width = 125;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            this.timeDataGridViewTextBoxColumn.Width = 125;
            // 
            // daysDataGridViewTextBoxColumn
            // 
            this.daysDataGridViewTextBoxColumn.DataPropertyName = "Days";
            this.daysDataGridViewTextBoxColumn.HeaderText = "Days";
            this.daysDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.daysDataGridViewTextBoxColumn.Name = "daysDataGridViewTextBoxColumn";
            this.daysDataGridViewTextBoxColumn.ReadOnly = true;
            this.daysDataGridViewTextBoxColumn.Width = 125;
            // 
            // remarkDataGridViewTextBoxColumn
            // 
            this.remarkDataGridViewTextBoxColumn.DataPropertyName = "Remark";
            this.remarkDataGridViewTextBoxColumn.HeaderText = "Remark";
            this.remarkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.remarkDataGridViewTextBoxColumn.Name = "remarkDataGridViewTextBoxColumn";
            this.remarkDataGridViewTextBoxColumn.ReadOnly = true;
            this.remarkDataGridViewTextBoxColumn.Width = 125;
            // 
            // Show_Prescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(844, 540);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Show_Prescription";
            this.Text = "Show_Prescription";
            this.Load += new System.EventHandler(this.Show_Prescription_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRMSDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PRMSDataSet7 pRMSDataSet7;
        private System.Windows.Forms.BindingSource prescriptionBindingSource;
        private PRMSDataSet7TableAdapters.PrescriptionTableAdapter prescriptionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn prescribeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn morningDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn afternoonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eveningDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn daysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
    }
}