namespace BiletOtomasyon
{
    partial class frmSatisYap
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
            this.btnComplete = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cmbSaloon = new System.Windows.Forms.ComboBox();
            this.lblKoltukNo = new System.Windows.Forms.Label();
            this.btnKoltukSec = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbOdemeSekli = new System.Windows.Forms.ComboBox();
            this.cmbSeans = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFilmName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnComplete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnComplete.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnComplete.Location = new System.Drawing.Point(720, 347);
            this.btnComplete.Margin = new System.Windows.Forms.Padding(4);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(193, 60);
            this.btnComplete.TabIndex = 27;
            this.btnComplete.Text = "Satışı Tamamla";
            this.btnComplete.UseVisualStyleBackColor = false;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(792, 254);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(121, 59);
            this.lblPrice.TabIndex = 26;
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbSaloon
            // 
            this.cmbSaloon.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbSaloon.FormattingEnabled = true;
            this.cmbSaloon.Location = new System.Drawing.Point(165, 211);
            this.cmbSaloon.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSaloon.Name = "cmbSaloon";
            this.cmbSaloon.Size = new System.Drawing.Size(183, 25);
            this.cmbSaloon.TabIndex = 25;
            this.cmbSaloon.SelectedIndexChanged += new System.EventHandler(this.cmbSaloon_SelectedIndexChanged);
            // 
            // lblKoltukNo
            // 
            this.lblKoltukNo.BackColor = System.Drawing.Color.White;
            this.lblKoltukNo.Location = new System.Drawing.Point(189, 347);
            this.lblKoltukNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKoltukNo.Name = "lblKoltukNo";
            this.lblKoltukNo.Size = new System.Drawing.Size(121, 59);
            this.lblKoltukNo.TabIndex = 24;
            this.lblKoltukNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKoltukSec
            // 
            this.btnKoltukSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKoltukSec.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKoltukSec.Location = new System.Drawing.Point(36, 347);
            this.btnKoltukSec.Margin = new System.Windows.Forms.Padding(4);
            this.btnKoltukSec.Name = "btnKoltukSec";
            this.btnKoltukSec.Size = new System.Drawing.Size(100, 59);
            this.btnKoltukSec.TabIndex = 23;
            this.btnKoltukSec.Text = "Koltuk Seçimi";
            this.btnKoltukSec.UseVisualStyleBackColor = true;
            this.btnKoltukSec.Click += new System.EventHandler(this.btnKoltukSec_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPhone.Location = new System.Drawing.Point(763, 43);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Mask = "00000000000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(183, 25);
            this.txtPhone.TabIndex = 22;
            this.txtPhone.ValidatingType = typeof(int);
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSurname.Location = new System.Drawing.Point(165, 133);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(183, 25);
            this.txtSurname.TabIndex = 21;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtName.Location = new System.Drawing.Point(165, 41);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(183, 25);
            this.txtName.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(608, 273);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Fiyat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(608, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Telefon Numarası";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(37, 216);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Salon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(37, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(37, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(608, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Ödeme Şekli";
            // 
            // cmbOdemeSekli
            // 
            this.cmbOdemeSekli.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOdemeSekli.FormattingEnabled = true;
            this.cmbOdemeSekli.Location = new System.Drawing.Point(763, 157);
            this.cmbOdemeSekli.Margin = new System.Windows.Forms.Padding(4);
            this.cmbOdemeSekli.Name = "cmbOdemeSekli";
            this.cmbOdemeSekli.Size = new System.Drawing.Size(183, 25);
            this.cmbOdemeSekli.TabIndex = 29;
            // 
            // cmbSeans
            // 
            this.cmbSeans.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbSeans.FormattingEnabled = true;
            this.cmbSeans.Location = new System.Drawing.Point(165, 288);
            this.cmbSeans.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSeans.Name = "cmbSeans";
            this.cmbSeans.Size = new System.Drawing.Size(183, 25);
            this.cmbSeans.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(37, 293);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Seans";
            // 
            // txtFilmName
            // 
            this.txtFilmName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFilmName.Location = new System.Drawing.Point(763, 100);
            this.txtFilmName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilmName.Name = "txtFilmName";
            this.txtFilmName.Size = new System.Drawing.Size(183, 25);
            this.txtFilmName.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(608, 105);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "Film Adı";
            // 
            // frmSatisYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1017, 464);
            this.Controls.Add(this.txtFilmName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbSeans);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbOdemeSekli);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.cmbSaloon);
            this.Controls.Add(this.lblKoltukNo);
            this.Controls.Add(this.btnKoltukSec);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSatisYap";
            this.Text = "Bilet Satışı";
            this.Load += new System.EventHandler(this.frmSatisYap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.ComboBox cmbSaloon;
        private System.Windows.Forms.Button btnKoltukSec;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblKoltukNo;
        public System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbOdemeSekli;
        public System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox cmbSeans;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtFilmName;
    }
}