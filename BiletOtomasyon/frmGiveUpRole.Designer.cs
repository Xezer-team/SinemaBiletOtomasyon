﻿namespace BiletOtomasyon
{
    partial class frmGiveUpRole
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
            this.dataGridModeList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridModeList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridModeList
            // 
            this.dataGridModeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridModeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridModeList.Location = new System.Drawing.Point(12, 34);
            this.dataGridModeList.Name = "dataGridModeList";
            this.dataGridModeList.RowTemplate.Height = 24;
            this.dataGridModeList.Size = new System.Drawing.Size(776, 413);
            this.dataGridModeList.TabIndex = 0;
            this.dataGridModeList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridModeList_CellMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(421, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rütbesini Düşüreceğiniz Kullanıcının Üzerine Çift Tıklayınız";
            // 
            // frmGiveUpRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridModeList);
            this.Name = "frmGiveUpRole";
            this.Text = "frmGiveUpRole";
            this.Load += new System.EventHandler(this.frmGiveUpRole_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridModeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridModeList;
        private System.Windows.Forms.Label label1;
    }
}