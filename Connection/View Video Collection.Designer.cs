namespace VideoClub
{
    partial class FrmView_Video_Collection
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
            this.CboVideos = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtRyear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtArating = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtMGenre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtQLeft = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PicBVideoImage = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBVideoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // CboVideos
            // 
            this.CboVideos.BackColor = System.Drawing.Color.White;
            this.CboVideos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CboVideos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboVideos.FormattingEnabled = true;
            this.CboVideos.Items.AddRange(new object[] {
            "",
            "Action",
            "Adventure",
            "Cannibal",
            "Cartoon",
            "Comedy",
            "Drama",
            "Horror",
            "Indian",
            "Romance",
            "Romantic Comdey",
            "Science-Fiction",
            "Thriller",
            "Yoruba"});
            this.CboVideos.Location = new System.Drawing.Point(1, 6);
            this.CboVideos.MaxDropDownItems = 100;
            this.CboVideos.Name = "CboVideos";
            this.CboVideos.Size = new System.Drawing.Size(350, 21);
            this.CboVideos.Sorted = true;
            this.CboVideos.TabIndex = 4;
            this.CboVideos.Tag = "Genre";
          
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.TxtRyear);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TxtArating);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TxtMGenre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxtQLeft);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.PicBVideoImage);
            this.panel1.Location = new System.Drawing.Point(352, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 370);
            this.panel1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtRyear
            // 
            this.TxtRyear.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TxtRyear.Location = new System.Drawing.Point(102, 314);
            this.TxtRyear.Name = "TxtRyear";
            this.TxtRyear.Size = new System.Drawing.Size(100, 20);
            this.TxtRyear.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Release Year";
            // 
            // TxtArating
            // 
            this.TxtArating.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TxtArating.Location = new System.Drawing.Point(102, 285);
            this.TxtArating.Name = "TxtArating";
            this.TxtArating.Size = new System.Drawing.Size(100, 20);
            this.TxtArating.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Age Rating";
            // 
            // TxtMGenre
            // 
            this.TxtMGenre.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TxtMGenre.Location = new System.Drawing.Point(102, 256);
            this.TxtMGenre.Name = "TxtMGenre";
            this.TxtMGenre.Size = new System.Drawing.Size(100, 20);
            this.TxtMGenre.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Movie Genre";
            // 
            // TxtQLeft
            // 
            this.TxtQLeft.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TxtQLeft.Location = new System.Drawing.Point(102, 227);
            this.TxtQLeft.Name = "TxtQLeft";
            this.TxtQLeft.Size = new System.Drawing.Size(100, 20);
            this.TxtQLeft.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quantity Left";
            // 
            // PicBVideoImage
            // 
            this.PicBVideoImage.BackColor = System.Drawing.Color.OldLace;
            this.PicBVideoImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicBVideoImage.Location = new System.Drawing.Point(12, 3);
            this.PicBVideoImage.Name = "PicBVideoImage";
            this.PicBVideoImage.Size = new System.Drawing.Size(230, 191);
            this.PicBVideoImage.TabIndex = 1;
            this.PicBVideoImage.TabStop = false;
            // 
            // FrmView_Video_Collection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(611, 378);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CboVideos);
            this.MaximizeBox = false;
            this.Name = "FrmView_Video_Collection";
            this.Text = "View_Video_Collection";
            this.Load += new System.EventHandler(this.View_Video_Collection_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBVideoImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CboVideos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtRyear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtArating;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtMGenre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtQLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PicBVideoImage;
        private System.Windows.Forms.Button button1;
    }
}