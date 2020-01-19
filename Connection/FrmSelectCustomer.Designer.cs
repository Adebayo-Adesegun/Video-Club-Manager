namespace VideoClub
{
    partial class FrmSelectCustomer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OptFNameSname = new System.Windows.Forms.RadioButton();
            this.optCustomerID = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.BtnGo = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TxtHomeNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DtpDateOFBirth = new System.Windows.Forms.DateTimePicker();
            this.TxtPhoneNumber = new System.Windows.Forms.TextBox();
            this.TxtPermAdd = new System.Windows.Forms.TextBox();
            this.TxtSuppAdd = new System.Windows.Forms.TextBox();
            this.TxtMiddleName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.OldLace;
            this.groupBox1.Controls.Add(this.OptFNameSname);
            this.groupBox1.Controls.Add(this.optCustomerID);
            this.groupBox1.Location = new System.Drawing.Point(8, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Customer By";
            // 
            // OptFNameSname
            // 
            this.OptFNameSname.AutoSize = true;
            this.OptFNameSname.Location = new System.Drawing.Point(10, 42);
            this.OptFNameSname.Name = "OptFNameSname";
            this.OptFNameSname.Size = new System.Drawing.Size(141, 17);
            this.OptFNameSname.TabIndex = 1;
            this.OptFNameSname.TabStop = true;
            this.OptFNameSname.Text = "First Name and Surname";
            this.OptFNameSname.UseVisualStyleBackColor = true;
            this.OptFNameSname.CheckedChanged += new System.EventHandler(this.OptFNameSname_CheckedChanged);
            // 
            // optCustomerID
            // 
            this.optCustomerID.AutoSize = true;
            this.optCustomerID.Location = new System.Drawing.Point(10, 19);
            this.optCustomerID.Name = "optCustomerID";
            this.optCustomerID.Size = new System.Drawing.Size(83, 17);
            this.optCustomerID.TabIndex = 0;
            this.optCustomerID.Text = "Customer ID";
            this.optCustomerID.UseVisualStyleBackColor = true;
            this.optCustomerID.CheckedChanged += new System.EventHandler(this.optCustomerID_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OldLace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtCustomerID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(188, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 34);
            this.panel1.TabIndex = 1;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(74, 5);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(54, 20);
            this.txtCustomerID.TabIndex = 4;
            this.txtCustomerID.Tag = "Customer ID";
            this.txtCustomerID.TextChanged += new System.EventHandler(this.txtCustomerID_TextChanged);
            this.txtCustomerID.Validating += new System.ComponentModel.CancelEventHandler(this.txtCustomerID_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customer ID";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OldLace;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.TxtSurname);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.TxtFirstName);
            this.panel2.Location = new System.Drawing.Point(334, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 63);
            this.panel2.TabIndex = 2;
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(79, 34);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(126, 20);
            this.TxtSurname.TabIndex = 8;
            this.TxtSurname.Tag = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "First Name";
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(79, 8);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(126, 20);
            this.TxtFirstName.TabIndex = 6;
            this.TxtFirstName.Tag = "First Name";
            // 
            // BtnGo
            // 
            this.BtnGo.BackColor = System.Drawing.Color.MintCream;
            this.BtnGo.Location = new System.Drawing.Point(552, 13);
            this.BtnGo.Name = "BtnGo";
            this.BtnGo.Size = new System.Drawing.Size(41, 46);
            this.BtnGo.TabIndex = 3;
            this.BtnGo.Text = "Go";
            this.BtnGo.UseVisualStyleBackColor = false;
            this.BtnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.OldLace;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.TxtHomeNumber);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.DtpDateOFBirth);
            this.panel3.Controls.Add(this.TxtPhoneNumber);
            this.panel3.Controls.Add(this.TxtPermAdd);
            this.panel3.Controls.Add(this.TxtSuppAdd);
            this.panel3.Controls.Add(this.TxtMiddleName);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(3, 85);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(433, 244);
            this.panel3.TabIndex = 3;
            // 
            // TxtHomeNumber
            // 
            this.TxtHomeNumber.Location = new System.Drawing.Point(115, 211);
            this.TxtHomeNumber.Name = "TxtHomeNumber";
            this.TxtHomeNumber.Size = new System.Drawing.Size(149, 20);
            this.TxtHomeNumber.TabIndex = 33;
            this.TxtHomeNumber.Tag = "Home Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Home Number:";
            // 
            // DtpDateOFBirth
            // 
            this.DtpDateOFBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDateOFBirth.Location = new System.Drawing.Point(319, 12);
            this.DtpDateOFBirth.Name = "DtpDateOFBirth";
            this.DtpDateOFBirth.Size = new System.Drawing.Size(103, 20);
            this.DtpDateOFBirth.TabIndex = 31;
            this.DtpDateOFBirth.Value = new System.DateTime(2014, 5, 17, 0, 0, 0, 0);
            // 
            // TxtPhoneNumber
            // 
            this.TxtPhoneNumber.Location = new System.Drawing.Point(115, 187);
            this.TxtPhoneNumber.Name = "TxtPhoneNumber";
            this.TxtPhoneNumber.Size = new System.Drawing.Size(149, 20);
            this.TxtPhoneNumber.TabIndex = 30;
            this.TxtPhoneNumber.Tag = "Mobile Number";
            // 
            // TxtPermAdd
            // 
            this.TxtPermAdd.Location = new System.Drawing.Point(115, 57);
            this.TxtPermAdd.Multiline = true;
            this.TxtPermAdd.Name = "TxtPermAdd";
            this.TxtPermAdd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtPermAdd.Size = new System.Drawing.Size(280, 62);
            this.TxtPermAdd.TabIndex = 29;
            this.TxtPermAdd.Tag = "Permanent Address";
            // 
            // TxtSuppAdd
            // 
            this.TxtSuppAdd.Location = new System.Drawing.Point(115, 125);
            this.TxtSuppAdd.Multiline = true;
            this.TxtSuppAdd.Name = "TxtSuppAdd";
            this.TxtSuppAdd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtSuppAdd.Size = new System.Drawing.Size(281, 58);
            this.TxtSuppAdd.TabIndex = 28;
            this.TxtSuppAdd.Tag = "Supplementary Address";
            // 
            // TxtMiddleName
            // 
            this.TxtMiddleName.Location = new System.Drawing.Point(85, 12);
            this.TxtMiddleName.Name = "TxtMiddleName";
            this.TxtMiddleName.Size = new System.Drawing.Size(134, 20);
            this.TxtMiddleName.TabIndex = 26;
            this.TxtMiddleName.Tag = "Middle Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Mobile Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Supplementary Add.:\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Permanent Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Date_Of_Birth:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Middle Name:";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.MintCream;
            this.BtnUpdate.Location = new System.Drawing.Point(486, 306);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(60, 23);
            this.BtnUpdate.TabIndex = 4;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.MintCream;
            this.BtnEdit.Location = new System.Drawing.Point(442, 274);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(60, 23);
            this.BtnEdit.TabIndex = 6;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // FrmSelectCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(596, 334);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnGo);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmSelectCustomer";
            this.Text = "View and Edit Customer Details";
            this.Load += new System.EventHandler(this.FrmSelectCustomer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton OptFNameSname;
        private System.Windows.Forms.RadioButton optCustomerID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnGo;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TxtHomeNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker DtpDateOFBirth;
        private System.Windows.Forms.TextBox TxtPhoneNumber;
        private System.Windows.Forms.TextBox TxtPermAdd;
        private System.Windows.Forms.TextBox TxtSuppAdd;
        private System.Windows.Forms.TextBox TxtMiddleName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnEdit;
    }
}