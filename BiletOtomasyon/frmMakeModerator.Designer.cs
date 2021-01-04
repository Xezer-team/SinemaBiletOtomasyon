namespace BiletOtomasyon
{
    partial class frmMakeModerator
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
            this.dataGridMod = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMod)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridMod
            // 
            this.dataGridMod.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridMod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMod.Location = new System.Drawing.Point(3, 31);
            this.dataGridMod.Name = "dataGridMod";
            this.dataGridMod.RowTemplate.Height = 24;
            this.dataGridMod.Size = new System.Drawing.Size(785, 407);
            this.dataGridMod.TabIndex = 0;
            this.dataGridMod.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridMod_CellMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(430, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcıyı Moderatör Yapmak İçin Üzerine Çift Tıklayınız";
            // 
            // frmMakeModerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridMod);
            this.Name = "frmMakeModerator";
            this.Text = "frmMakeModerator";
            this.Load += new System.EventHandler(this.frmMakeModerator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridMod;
        private System.Windows.Forms.Label label1;
    }
}