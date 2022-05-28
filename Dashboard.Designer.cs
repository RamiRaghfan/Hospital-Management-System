
namespace E_Hospital
{
    partial class Dashboard
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
            this.btnCreateP = new System.Windows.Forms.Button();
            this.btnAddDiag = new System.Windows.Forms.Button();
            this.btnShowPatients = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDescr = new System.Windows.Forms.TextBox();
            this.patientAddLabel = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.comboSex = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtBldType = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtContactNr = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateP
            // 
            this.btnCreateP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCreateP.Location = new System.Drawing.Point(34, 180);
            this.btnCreateP.Name = "btnCreateP";
            this.btnCreateP.Size = new System.Drawing.Size(177, 37);
            this.btnCreateP.TabIndex = 0;
            this.btnCreateP.Text = "Add Patient";
            this.btnCreateP.UseVisualStyleBackColor = false;
            this.btnCreateP.Click += new System.EventHandler(this.btnCreateP_Click);
            // 
            // btnAddDiag
            // 
            this.btnAddDiag.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddDiag.Location = new System.Drawing.Point(34, 270);
            this.btnAddDiag.Name = "btnAddDiag";
            this.btnAddDiag.Size = new System.Drawing.Size(177, 37);
            this.btnAddDiag.TabIndex = 1;
            this.btnAddDiag.Text = "Add Diagnosis Info";
            this.btnAddDiag.UseVisualStyleBackColor = false;
            this.btnAddDiag.Click += new System.EventHandler(this.btnAddDiag_Click);
            // 
            // btnShowPatients
            // 
            this.btnShowPatients.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnShowPatients.Location = new System.Drawing.Point(34, 358);
            this.btnShowPatients.Name = "btnShowPatients";
            this.btnShowPatients.Size = new System.Drawing.Size(177, 37);
            this.btnShowPatients.TabIndex = 2;
            this.btnShowPatients.Text = "Patients";
            this.btnShowPatients.UseVisualStyleBackColor = false;
            this.btnShowPatients.Click += new System.EventHandler(this.btnShowPatients_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::E_Hospital.Properties.Resources.clipart;
            this.pictureBox1.Location = new System.Drawing.Point(491, 192);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 252);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "CONTROLLER";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(73, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDescr);
            this.panel1.Controls.Add(this.patientAddLabel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.comboSex);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtWeight);
            this.panel1.Controls.Add(this.txtBldType);
            this.panel1.Controls.Add(this.txtAge);
            this.panel1.Controls.Add(this.txtContactNr);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Location = new System.Drawing.Point(302, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 547);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtDescr
            // 
            this.txtDescr.Location = new System.Drawing.Point(337, 388);
            this.txtDescr.Name = "txtDescr";
            this.txtDescr.Size = new System.Drawing.Size(465, 27);
            this.txtDescr.TabIndex = 20;
            // 
            // patientAddLabel
            // 
            this.patientAddLabel.AutoSize = true;
            this.patientAddLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.patientAddLabel.Location = new System.Drawing.Point(337, 0);
            this.patientAddLabel.Name = "patientAddLabel";
            this.patientAddLabel.Size = new System.Drawing.Size(172, 25);
            this.patientAddLabel.TabIndex = 19;
            this.patientAddLabel.Text = "Add New Patient";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(337, 500);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // comboSex
            // 
            this.comboSex.FormattingEnabled = true;
            this.comboSex.Items.AddRange(new object[] {
            "Male ",
            "Female",
            "Other"});
            this.comboSex.Location = new System.Drawing.Point(337, 231);
            this.comboSex.Name = "comboSex";
            this.comboSex.Size = new System.Drawing.Size(465, 28);
            this.comboSex.TabIndex = 16;
            this.comboSex.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(140, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Adress";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(140, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Blood type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(140, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Age";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sex";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Contact Number";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Weight (In Kg)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Case description";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(337, 334);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(465, 27);
            this.txtWeight.TabIndex = 6;
            this.txtWeight.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // txtBldType
            // 
            this.txtBldType.Location = new System.Drawing.Point(337, 282);
            this.txtBldType.Name = "txtBldType";
            this.txtBldType.Size = new System.Drawing.Size(465, 27);
            this.txtBldType.TabIndex = 5;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(337, 183);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(465, 27);
            this.txtAge.TabIndex = 3;
            this.txtAge.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtContactNr
            // 
            this.txtContactNr.Location = new System.Drawing.Point(337, 137);
            this.txtContactNr.Name = "txtContactNr";
            this.txtContactNr.Size = new System.Drawing.Size(465, 27);
            this.txtContactNr.TabIndex = 2;
            this.txtContactNr.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(337, 93);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(465, 27);
            this.txtAddress.TabIndex = 1;
            this.txtAddress.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(337, 50);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(465, 27);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(305, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(822, 547);
            this.panel2.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(784, 396);
            this.dataGridView1.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(316, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 29);
            this.label10.TabIndex = 5;
            this.label10.Text = "All Patients";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 595);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnShowPatients);
            this.Controls.Add(this.btnAddDiag);
            this.Controls.Add(this.btnCreateP);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateP;
        private System.Windows.Forms.Button btnAddDiag;
        private System.Windows.Forms.Button btnShowPatients;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtBldType;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtContactNr;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox comboSex;
        private System.Windows.Forms.Label patientAddLabel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtDescr;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}