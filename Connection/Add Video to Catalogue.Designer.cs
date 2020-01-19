namespace VideoClub
{
    partial class FrmAdd_Video_to_Catalogue
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
            this.PicBVideoImage = new System.Windows.Forms.PictureBox();
            this.btnChooseF = new System.Windows.Forms.Button();
            this.TxtFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtVideoName = new System.Windows.Forms.TextBox();
            this.Nudage = new System.Windows.Forms.NumericUpDown();
            this.DtpYear = new System.Windows.Forms.DateTimePicker();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboGenre = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PicBVideoImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nudage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PicBVideoImage
            // 
            this.PicBVideoImage.BackColor = System.Drawing.Color.OldLace;
            this.PicBVideoImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicBVideoImage.Location = new System.Drawing.Point(12, 26);
            this.PicBVideoImage.Name = "PicBVideoImage";
            this.PicBVideoImage.Size = new System.Drawing.Size(230, 191);
            this.PicBVideoImage.TabIndex = 0;
            this.PicBVideoImage.TabStop = false;
            // 
            // btnChooseF
            // 
            this.btnChooseF.BackColor = System.Drawing.Color.MintCream;
            this.btnChooseF.Location = new System.Drawing.Point(204, 223);
            this.btnChooseF.Name = "btnChooseF";
            this.btnChooseF.Size = new System.Drawing.Size(75, 23);
            this.btnChooseF.TabIndex = 1;
            this.btnChooseF.Text = "Choose File";
            this.btnChooseF.UseVisualStyleBackColor = false;
            this.btnChooseF.Click += new System.EventHandler(this.btnChooseF_Click);
            // 
            // TxtFilePath
            // 
            this.TxtFilePath.Location = new System.Drawing.Point(12, 226);
            this.TxtFilePath.Name = "TxtFilePath";
            this.TxtFilePath.Size = new System.Drawing.Size(186, 20);
            this.TxtFilePath.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Year Of Release";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Age Rating :";
            // 
            // TxtVideoName
            // 
            this.TxtVideoName.Location = new System.Drawing.Point(94, 3);
            this.TxtVideoName.Name = "TxtVideoName";
            this.TxtVideoName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TxtVideoName.Size = new System.Drawing.Size(192, 20);
            this.TxtVideoName.TabIndex = 2;
            this.TxtVideoName.Tag = "Name";
            // 
            // Nudage
            // 
            this.Nudage.Location = new System.Drawing.Point(94, 90);
            this.Nudage.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Nudage.Minimum = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.Nudage.Name = "Nudage";
            this.Nudage.Size = new System.Drawing.Size(55, 20);
            this.Nudage.TabIndex = 5;
            this.Nudage.Tag = "Age Rating";
            this.Nudage.Value = new decimal(new int[] {
            13,
            0,
            0,
            0});
            // 
            // DtpYear
            // 
            this.DtpYear.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpYear.Location = new System.Drawing.Point(94, 55);
            this.DtpYear.Name = "DtpYear";
            this.DtpYear.Size = new System.Drawing.Size(78, 20);
            this.DtpYear.TabIndex = 4;
            this.DtpYear.Tag = "Year Of Release";
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.BackColor = System.Drawing.Color.MintCream;
            this.BtnSubmit.Location = new System.Drawing.Point(489, 226);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(75, 23);
            this.BtnSubmit.TabIndex = 7;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = false;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(94, 124);
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(55, 20);
            this.nudQuantity.TabIndex = 6;
            this.nudQuantity.Tag = "Quantity";
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 10;
            this.label4.Tag = "Quantity";
            this.label4.Text = "Quantity\r\n";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OldLace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cboGenre);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nudQuantity);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TxtVideoName);
            this.panel1.Controls.Add(this.DtpYear);
            this.panel1.Controls.Add(this.Nudage);
            this.panel1.Location = new System.Drawing.Point(261, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 163);
            this.panel1.TabIndex = 12;
            // 
            // cboGenre
            // 
            this.cboGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenre.FormattingEnabled = true;
            this.cboGenre.Items.AddRange(new object[] {
            "Action",
            "Thriller",
            "Drama",
            "Horror",
            "Cannibal",
            "Cartoon",
            "Yoruba",
            "Romance",
            "Comedy",
            "Science-Fiction",
            "Romantic Comdey",
            "Indian",
            "Adventure",
            ""});
            this.cboGenre.Location = new System.Drawing.Point(94, 27);
            this.cboGenre.Name = "cboGenre";
            this.cboGenre.Size = new System.Drawing.Size(157, 21);
            this.cboGenre.TabIndex = 3;
            this.cboGenre.Tag = "Genre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Genre";
            // 
            // openFD
            // 
            this.openFD.FileName = "Choose image file";
            // 
            // FrmAdd_Video_to_Catalogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(566, 250);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.TxtFilePath);
            this.Controls.Add(this.btnChooseF);
            this.Controls.Add(this.PicBVideoImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmAdd_Video_to_Catalogue";
            this.Text = "Add_Video_to_Catalogue";
            this.Load += new System.EventHandler(this.FrmAdd_Video_to_Catalogue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBVideoImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nudage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBVideoImage;
        private System.Windows.Forms.Button btnChooseF;
        private System.Windows.Forms.TextBox TxtFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtVideoName;
        private System.Windows.Forms.NumericUpDown Nudage;
        private System.Windows.Forms.DateTimePicker DtpYear;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.ComboBox cboGenre;
        private System.Windows.Forms.Label label5;
    }
}