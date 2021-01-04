namespace BiletOtomasyon
{
    partial class frmFilmEkle
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbFilmType = new System.Windows.Forms.ComboBox();
            this.cmbFilmCategory = new System.Windows.Forms.ComboBox();
            this.cmbSaloon = new System.Windows.Forms.ComboBox();
            this.txtFilmYear = new System.Windows.Forms.TextBox();
            this.txtFilmName = new System.Windows.Forms.TextBox();
            this.cmbFilmSeason = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnPictureAdd = new System.Windows.Forms.Button();
            this.Yeni = new System.Windows.Forms.OpenFileDialog();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSeansAdd = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film Resim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Film Adı";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Film Yılı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Salon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(385, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Film Türü";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(385, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Film Tarzı";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pictureBox1.Location = new System.Drawing.Point(128, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // cmbFilmType
            // 
            this.cmbFilmType.FormattingEnabled = true;
            this.cmbFilmType.Location = new System.Drawing.Point(467, 102);
            this.cmbFilmType.Name = "cmbFilmType";
            this.cmbFilmType.Size = new System.Drawing.Size(121, 24);
            this.cmbFilmType.TabIndex = 7;
            // 
            // cmbFilmCategory
            // 
            this.cmbFilmCategory.FormattingEnabled = true;
            this.cmbFilmCategory.Location = new System.Drawing.Point(467, 64);
            this.cmbFilmCategory.Name = "cmbFilmCategory";
            this.cmbFilmCategory.Size = new System.Drawing.Size(121, 24);
            this.cmbFilmCategory.TabIndex = 8;
            // 
            // cmbSaloon
            // 
            this.cmbSaloon.FormattingEnabled = true;
            this.cmbSaloon.Location = new System.Drawing.Point(467, 25);
            this.cmbSaloon.Name = "cmbSaloon";
            this.cmbSaloon.Size = new System.Drawing.Size(121, 24);
            this.cmbSaloon.TabIndex = 9;
            // 
            // txtFilmYear
            // 
            this.txtFilmYear.Location = new System.Drawing.Point(128, 322);
            this.txtFilmYear.Name = "txtFilmYear";
            this.txtFilmYear.Size = new System.Drawing.Size(156, 22);
            this.txtFilmYear.TabIndex = 10;
            // 
            // txtFilmName
            // 
            this.txtFilmName.Location = new System.Drawing.Point(128, 239);
            this.txtFilmName.Name = "txtFilmName";
            this.txtFilmName.Size = new System.Drawing.Size(156, 22);
            this.txtFilmName.TabIndex = 11;
            // 
            // cmbFilmSeason
            // 
            this.cmbFilmSeason.FormattingEnabled = true;
            this.cmbFilmSeason.Location = new System.Drawing.Point(467, 142);
            this.cmbFilmSeason.Name = "cmbFilmSeason";
            this.cmbFilmSeason.Size = new System.Drawing.Size(121, 24);
            this.cmbFilmSeason.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(384, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Oturum";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(479, 309);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 32);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Film Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPictureAdd
            // 
            this.btnPictureAdd.Location = new System.Drawing.Point(29, 61);
            this.btnPictureAdd.Name = "btnPictureAdd";
            this.btnPictureAdd.Size = new System.Drawing.Size(93, 24);
            this.btnPictureAdd.TabIndex = 15;
            this.btnPictureAdd.Text = "Resim Ekle";
            this.btnPictureAdd.UseVisualStyleBackColor = true;
            this.btnPictureAdd.Click += new System.EventHandler(this.btnPictureAdd_Click);
            // 
            // Yeni
            // 
            this.Yeni.FileName = "openFileDialog1";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(128, 280);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(156, 22);
            this.txtPrice.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Ücret";
            // 
            // btnSeansAdd
            // 
            this.btnSeansAdd.Location = new System.Drawing.Point(479, 172);
            this.btnSeansAdd.Name = "btnSeansAdd";
            this.btnSeansAdd.Size = new System.Drawing.Size(109, 32);
            this.btnSeansAdd.TabIndex = 18;
            this.btnSeansAdd.Text = "Seans Ekle";
            this.btnSeansAdd.UseVisualStyleBackColor = true;
            this.btnSeansAdd.Click += new System.EventHandler(this.btnSeansAdd_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(467, 209);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(121, 84);
            this.listBox1.TabIndex = 19;
            // 
            // frmFilmEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 381);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnSeansAdd);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnPictureAdd);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbFilmSeason);
            this.Controls.Add(this.txtFilmName);
            this.Controls.Add(this.txtFilmYear);
            this.Controls.Add(this.cmbSaloon);
            this.Controls.Add(this.cmbFilmCategory);
            this.Controls.Add(this.cmbFilmType);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmFilmEkle";
            this.Text = "Film Ekle";
            this.Load += new System.EventHandler(this.frmFilmEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbFilmType;
        private System.Windows.Forms.ComboBox cmbFilmCategory;
        private System.Windows.Forms.ComboBox cmbSaloon;
        private System.Windows.Forms.TextBox txtFilmYear;
        private System.Windows.Forms.TextBox txtFilmName;
        private System.Windows.Forms.ComboBox cmbFilmSeason;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnPictureAdd;
        private System.Windows.Forms.OpenFileDialog Yeni;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSeansAdd;
        private System.Windows.Forms.ListBox listBox1;
    }
}