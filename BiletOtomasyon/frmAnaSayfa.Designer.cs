namespace BiletOtomasyon
{
    partial class frmAnaSayfa
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.salonDurumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toplamSatışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.yöneticiAyarlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcılarListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yöneticilerListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yetkiVerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yetkiAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.viewMenu,
            this.filmToolStripMenuItem,
            this.yöneticiAyarlarıToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1020, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(86, 24);
            this.fileMenu.Text = "Bilet Satış";
            this.fileMenu.Click += new System.EventHandler(this.fileMenu_Click);
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salonDurumToolStripMenuItem});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(75, 24);
            this.editMenu.Text = "Salonlar";
            // 
            // salonDurumToolStripMenuItem
            // 
            this.salonDurumToolStripMenuItem.Name = "salonDurumToolStripMenuItem";
            this.salonDurumToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.salonDurumToolStripMenuItem.Text = "Salon Ekle";
            this.salonDurumToolStripMenuItem.Click += new System.EventHandler(this.salonDurumToolStripMenuItem_Click);
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toplamSatışToolStripMenuItem});
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(94, 24);
            this.viewMenu.Text = "Raporlama";
            // 
            // toplamSatışToolStripMenuItem
            // 
            this.toplamSatışToolStripMenuItem.Name = "toplamSatışToolStripMenuItem";
            this.toplamSatışToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.toplamSatışToolStripMenuItem.Text = "Toplam Satış";
            this.toplamSatışToolStripMenuItem.Click += new System.EventHandler(this.toplamSatışToolStripMenuItem_Click);
            // 
            // filmToolStripMenuItem
            // 
            this.filmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filmEkleToolStripMenuItem,
            this.fToolStripMenuItem});
            this.filmToolStripMenuItem.Name = "filmToolStripMenuItem";
            this.filmToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.filmToolStripMenuItem.Text = "Film";
            // 
            // filmEkleToolStripMenuItem
            // 
            this.filmEkleToolStripMenuItem.Name = "filmEkleToolStripMenuItem";
            this.filmEkleToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.filmEkleToolStripMenuItem.Text = "Film Ekle";
            this.filmEkleToolStripMenuItem.Click += new System.EventHandler(this.filmEkleToolStripMenuItem_Click);
            // 
            // fToolStripMenuItem
            // 
            this.fToolStripMenuItem.Name = "fToolStripMenuItem";
            this.fToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.fToolStripMenuItem.Text = "Film Listesi";
            this.fToolStripMenuItem.Click += new System.EventHandler(this.fToolStripMenuItem_Click);
            // 
            // yöneticiAyarlarıToolStripMenuItem
            // 
            this.yöneticiAyarlarıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcılarListesiToolStripMenuItem,
            this.yöneticilerListesiToolStripMenuItem,
            this.yetkiVerToolStripMenuItem,
            this.yetkiAlToolStripMenuItem});
            this.yöneticiAyarlarıToolStripMenuItem.Name = "yöneticiAyarlarıToolStripMenuItem";
            this.yöneticiAyarlarıToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.yöneticiAyarlarıToolStripMenuItem.Text = "Yönetici Ayarları";
            // 
            // kullanıcılarListesiToolStripMenuItem
            // 
            this.kullanıcılarListesiToolStripMenuItem.Name = "kullanıcılarListesiToolStripMenuItem";
            this.kullanıcılarListesiToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.kullanıcılarListesiToolStripMenuItem.Text = "Kullanıcılar Listesi";
            this.kullanıcılarListesiToolStripMenuItem.Click += new System.EventHandler(this.kullanıcılarListesiToolStripMenuItem_Click);
            // 
            // yöneticilerListesiToolStripMenuItem
            // 
            this.yöneticilerListesiToolStripMenuItem.Name = "yöneticilerListesiToolStripMenuItem";
            this.yöneticilerListesiToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.yöneticilerListesiToolStripMenuItem.Text = "Yöneticiler Listesi";
            this.yöneticilerListesiToolStripMenuItem.Click += new System.EventHandler(this.yöneticilerListesiToolStripMenuItem_Click);
            // 
            // yetkiVerToolStripMenuItem
            // 
            this.yetkiVerToolStripMenuItem.Name = "yetkiVerToolStripMenuItem";
            this.yetkiVerToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.yetkiVerToolStripMenuItem.Text = "Yetki Ver";
            this.yetkiVerToolStripMenuItem.Click += new System.EventHandler(this.yetkiVerToolStripMenuItem_Click);
            // 
            // yetkiAlToolStripMenuItem
            // 
            this.yetkiAlToolStripMenuItem.Name = "yetkiAlToolStripMenuItem";
            this.yetkiAlToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.yetkiAlToolStripMenuItem.Text = "Yetki Al";
            this.yetkiAlToolStripMenuItem.Click += new System.EventHandler(this.yetkiAlToolStripMenuItem_Click);
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 489);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAnaSayfa";
            this.Text = "frmAnaSayfa";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem salonDurumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toplamSatışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yöneticiAyarlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcılarListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yöneticilerListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yetkiVerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yetkiAlToolStripMenuItem;
    }
}



