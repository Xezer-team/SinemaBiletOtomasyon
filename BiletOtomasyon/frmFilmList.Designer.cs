namespace BiletOtomasyon
{
    partial class frmFilmList
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
            this.dataGridFilmList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFilmList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridFilmList
            // 
            this.dataGridFilmList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFilmList.Location = new System.Drawing.Point(12, 25);
            this.dataGridFilmList.Name = "dataGridFilmList";
            this.dataGridFilmList.RowTemplate.Height = 24;
            this.dataGridFilmList.Size = new System.Drawing.Size(984, 422);
            this.dataGridFilmList.TabIndex = 0;
            this.dataGridFilmList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridFilmList_CellMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(791, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filmi Seçmek İçin Çift Tıklayınız";
            // 
            // frmFilmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridFilmList);
            this.Name = "frmFilmList";
            this.Text = "frmFilmList";
            this.Load += new System.EventHandler(this.frmFilmList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFilmList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridFilmList;
        private System.Windows.Forms.Label label1;
    }
}