namespace VideoClub
{
    partial class FrmTransactionTracker
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
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtVideoName = new System.Windows.Forms.TextBox();
            this.DtpDateBorrowed = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DtpRdate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtAmountPaid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtLRFee = new System.Windows.Forms.TextBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnMakeTrans = new System.Windows.Forms.Button();
            this.BtnProcess = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(93, 25);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(71, 20);
            this.txtCustomerID.TabIndex = 6;
            this.txtCustomerID.Tag = "Customer ID";
            this.txtCustomerID.TextChanged += new System.EventHandler(this.txtCustomerID_TextChanged);
            this.txtCustomerID.Validating += new System.ComponentModel.CancelEventHandler(this.txtCustomerID_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Customer ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Video Name";
            // 
            // TxtVideoName
            // 
            this.TxtVideoName.Location = new System.Drawing.Point(93, 53);
            this.TxtVideoName.Name = "TxtVideoName";
            this.TxtVideoName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TxtVideoName.Size = new System.Drawing.Size(192, 20);
            this.TxtVideoName.TabIndex = 7;
            this.TxtVideoName.Tag = "Name";
            // 
            // DtpDateBorrowed
            // 
            this.DtpDateBorrowed.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDateBorrowed.Location = new System.Drawing.Point(93, 81);
            this.DtpDateBorrowed.Name = "DtpDateBorrowed";
            this.DtpDateBorrowed.Size = new System.Drawing.Size(98, 20);
            this.DtpDateBorrowed.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Date Borrowed";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Return Date";
            // 
            // DtpRdate
            // 
            this.DtpRdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpRdate.Location = new System.Drawing.Point(101, 55);
            this.DtpRdate.Name = "DtpRdate";
            this.DtpRdate.Size = new System.Drawing.Size(103, 20);
            this.DtpRdate.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Amount Paid";
            // 
            // TxtAmountPaid
            // 
            this.TxtAmountPaid.Location = new System.Drawing.Point(93, 108);
            this.TxtAmountPaid.Name = "TxtAmountPaid";
            this.TxtAmountPaid.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TxtAmountPaid.Size = new System.Drawing.Size(92, 20);
            this.TxtAmountPaid.TabIndex = 13;
            this.TxtAmountPaid.Tag = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Late Return Fee";
            // 
            // TxtLRFee
            // 
            this.TxtLRFee.Location = new System.Drawing.Point(101, 29);
            this.TxtLRFee.Name = "TxtLRFee";
            this.TxtLRFee.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TxtLRFee.Size = new System.Drawing.Size(83, 20);
            this.TxtLRFee.TabIndex = 15;
            this.TxtLRFee.Tag = "Name";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(93, 134);
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(55, 20);
            this.nudQuantity.TabIndex = 17;
            this.nudQuantity.Tag = "Quantity";
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 18;
            this.label7.Tag = "Quantity";
            this.label7.Text = "Quantity\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.OldLace;
            this.groupBox1.Controls.Add(this.TxtVideoName);
            this.groupBox1.Controls.Add(this.nudQuantity);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCustomerID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DtpDateBorrowed);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtAmountPaid);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 190);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transaction Details";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.OldLace;
            this.groupBox2.Controls.Add(this.TxtLRFee);
            this.groupBox2.Controls.Add(this.DtpRdate);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(311, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 100);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Late Return Details";
            // 
            // BtnMakeTrans
            // 
            this.BtnMakeTrans.AutoSize = true;
            this.BtnMakeTrans.BackColor = System.Drawing.Color.MintCream;
            this.BtnMakeTrans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMakeTrans.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnMakeTrans.FlatAppearance.BorderSize = 20;
            this.BtnMakeTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMakeTrans.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnMakeTrans.Location = new System.Drawing.Point(414, 186);
            this.BtnMakeTrans.Name = "BtnMakeTrans";
            this.BtnMakeTrans.Size = new System.Drawing.Size(119, 31);
            this.BtnMakeTrans.TabIndex = 21;
            this.BtnMakeTrans.Text = "Make Transaction";
            this.BtnMakeTrans.UseVisualStyleBackColor = false;
            this.BtnMakeTrans.Click += new System.EventHandler(this.BtnMakeTrans_Click);
            // 
            // BtnProcess
            // 
            this.BtnProcess.BackColor = System.Drawing.Color.MintCream;
            this.BtnProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProcess.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnProcess.Location = new System.Drawing.Point(458, 123);
            this.BtnProcess.Name = "BtnProcess";
            this.BtnProcess.Size = new System.Drawing.Size(75, 23);
            this.BtnProcess.TabIndex = 22;
            this.BtnProcess.Text = "Process";
            this.BtnProcess.UseVisualStyleBackColor = false;
            this.BtnProcess.Click += new System.EventHandler(this.BtnProcess_Click);
            // 
            // FrmTransactionTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(541, 216);
            this.Controls.Add(this.BtnProcess);
            this.Controls.Add(this.BtnMakeTrans);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FrmTransactionTracker";
            this.Text = "FrmTransactionTracker";
            this.Load += new System.EventHandler(this.FrmTransactionTracker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtVideoName;
        private System.Windows.Forms.DateTimePicker DtpDateBorrowed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DtpRdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtAmountPaid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtLRFee;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnMakeTrans;
        private System.Windows.Forms.Button BtnProcess;
    }
}