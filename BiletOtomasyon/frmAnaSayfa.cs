using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiletOtomasyon
{
    public partial class frmAnaSayfa : Form
    {
      

        public frmAnaSayfa()
        {
            InitializeComponent();
        }

     
        private void fileMenu_Click(object sender, EventArgs e)
        {
            frmFilmList list = new frmFilmList();
            list.Show();
        }

        private void salonDurumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalonEkle ekle = new frmSalonEkle();
            ekle.Show();
        }

        private void toplamSatışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTotalSales sales = new frmTotalSales();
            sales.Tag = Tag;
            sales.Show();
        }

        private void filmEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFilmEkle ekle = new frmFilmEkle();
            ekle.Tag = Tag;
            ekle.Show();
        }

        private void fToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFilmList list = new frmFilmList();
            list.Tag = Tag;
            list.Show();
        }

        private void kullanıcılarListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserList list = new frmUserList();
            list.Tag = Tag;
            list.Show();
        }

        private void yöneticilerListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminList list = new frmAdminList();
            list.Tag = Tag;
            list.Show();
        }

        private void yetkiVerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMakeModerator list = new frmMakeModerator();
            list.Tag = Tag;
            list.Show();
        }

        private void yetkiAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGiveUpRole list = new frmGiveUpRole();
            list.Tag = Tag;
            list.Show();
        }
    }
}
