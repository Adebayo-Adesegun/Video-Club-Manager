namespace VideoClub
{
    partial class FrmRegForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.TxtMiddleName = new System.Windows.Forms.TextBox();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.TxtSuppAdd = new System.Windows.Forms.TextBox();
            this.TxtPermAdd = new System.Windows.Forms.TextBox();
            this.TxtPhoneNumber = new System.Windows.Forms.TextBox();
            this.DtpDateOFBirth = new System.Windows.Forms.DateTimePicker();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtHomeNumber = new System.Windows.Forms.TextBox();
            this.LblDisplayMessage = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Middle Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Surname:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date_Of_Birth:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Permanent Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Supplementary Add.:\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mobile Number:";
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(97, 16);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(150, 20);
            this.TxtFirstName.TabIndex = 1;
            this.TxtFirstName.Tag = "First Name";
            // 
            // TxtMiddleName
            // 
            this.TxtMiddleName.Location = new System.Drawing.Point(97, 47);
            this.TxtMiddleName.Name = "TxtMiddleName";
            this.TxtMiddleName.Size = new System.Drawing.Size(150, 20);
            this.TxtMiddleName.TabIndex = 2;
            this.TxtMiddleName.Tag = "Middle Name";
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(97, 77);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(150, 20);
            this.TxtSurname.TabIndex = 3;
            this.TxtSurname.Tag = "Surname";
            this.TxtSurname.TextChanged += new System.EventHandler(this.TxtSurname_TextChanged);
            // 
            // TxtSuppAdd
            // 
            this.TxtSuppAdd.Location = new System.Drawing.Point(120, 93);
            this.TxtSuppAdd.Multiline = true;
            this.TxtSuppAdd.Name = "TxtSuppAdd";
            this.TxtSuppAdd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtSuppAdd.Size = new System.Drawing.Size(281, 58);
            this.TxtSuppAdd.TabIndex = 6;
            this.TxtSuppAdd.Tag = "Supplementary Address";
            // 
            // TxtPermAdd
            // 
            this.TxtPermAdd.Location = new System.Drawing.Point(120, 19);
            this.TxtPermAdd.Multiline = true;
            this.TxtPermAdd.Name = "TxtPermAdd";
            this.TxtPermAdd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtPermAdd.Size = new System.Drawing.Size(280, 62);
            this.TxtPermAdd.TabIndex = 5;
            this.TxtPermAdd.Tag = "Permanent Address";
            // 
            // TxtPhoneNumber
            // 
            this.TxtPhoneNumber.Location = new System.Drawing.Point(120, 165);
            this.TxtPhoneNumber.Name = "TxtPhoneNumber";
            this.TxtPhoneNumber.Size = new System.Drawing.Size(149, 20);
            this.TxtPhoneNumber.TabIndex = 7;
            this.TxtPhoneNumber.Tag = "Mobile Number";
            // 
            // DtpDateOFBirth
            // 
            this.DtpDateOFBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDateOFBirth.Location = new System.Drawing.Point(97, 109);
            this.DtpDateOFBirth.Name = "DtpDateOFBirth";
            this.DtpDateOFBirth.Size = new System.Drawing.Size(103, 20);
            this.DtpDateOFBirth.TabIndex = 4;
            this.DtpDateOFBirth.Value = new System.DateTime(2014, 5, 17, 0, 0, 0, 0);
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.BackColor = System.Drawing.Color.OldLace;
            this.BtnSubmit.Location = new System.Drawing.Point(352, 428);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(75, 23);
            this.BtnSubmit.TabIndex = 9;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = false;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Home Number:";
            // 
            // TxtHomeNumber
            // 
            this.TxtHomeNumber.Location = new System.Drawing.Point(120, 196);
            this.TxtHomeNumber.Name = "TxtHomeNumber";
            this.TxtHomeNumber.Size = new System.Drawing.Size(149, 20);
            this.TxtHomeNumber.TabIndex = 8;
            this.TxtHomeNumber.Tag = "Home Number";
            // 
            // LblDisplayMessage
            // 
            this.LblDisplayMessage.AutoSize = true;
            this.LblDisplayMessage.Location = new System.Drawing.Point(5, 357);
            this.LblDisplayMessage.Name = "LblDisplayMessage";
            this.LblDisplayMessage.Size = new System.Drawing.Size(0, 13);
            this.LblDisplayMessage.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.OldLace;
            this.groupBox1.Controls.Add(this.TxtMiddleName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtFirstName);
            this.groupBox1.Controls.Add(this.TxtSurname);
            this.groupBox1.Controls.Add(this.DtpDateOFBirth);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 152);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Personal Details";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.OldLace;
            this.groupBox2.Controls.Add(this.TxtPermAdd);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TxtHomeNumber);
            this.groupBox2.Controls.Add(this.TxtSuppAdd);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.TxtPhoneNumber);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(8, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 225);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contact Details";
            // 
            // FrmRegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(439, 458);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LblDisplayMessage);
            this.Controls.Add(this.BtnSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmRegForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registration_Form";
            this.Load += new System.EventHandler(this.FrmRegForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.TextBox TxtMiddleName;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.TextBox TxtSuppAdd;
        private System.Windows.Forms.TextBox TxtPermAdd;
        private System.Windows.Forms.TextBox TxtPhoneNumber;
        private System.Windows.Forms.DateTimePicker DtpDateOFBirth;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtHomeNumber;
        private System.Windows.Forms.Label LblDisplayMessage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}