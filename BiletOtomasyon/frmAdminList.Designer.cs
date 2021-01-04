namespace BiletOtomasyon
{
    partial class frmAdminList
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
            this.dataGridAdminList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdminList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridAdminList
            // 
            this.dataGridAdminList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAdminList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAdminList.Location = new System.Drawing.Point(12, 12);
            this.dataGridAdminList.Name = "dataGridAdminList";
            this.dataGridAdminList.RowTemplate.Height = 24;
            this.dataGridAdminList.Size = new System.Drawing.Size(787, 426);
            this.dataGridAdminList.TabIndex = 0;
            // 
            // frmAdminList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridAdminList);
            this.Name = "frmAdminList";
            this.Text = "frmAdminList";
            this.Load += new System.EventHandler(this.frmAdminList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdminList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridAdminList;
    }
}