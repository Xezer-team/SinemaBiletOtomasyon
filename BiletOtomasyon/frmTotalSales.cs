using BiletOtomasyon.Entities;
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
    public partial class frmTotalSales : Form
    {
        public frmTotalSales()
        {
            InitializeComponent();
        }
        BiletContext ctx = new BiletContext();
        private void frmTotalSales_Load(object sender, EventArgs e)
        {
            if (Tag == null)
            {
                MessageBox.Show("Bu bölüme giriş yetkiniz yoktur. Lütfen yetkili bir kullanıcı ile giriş yapınız!");
                Dispose();
                return;
            }
            var roleOfUsers = (List<roleOfUsers>)Tag;
            if (!roleOfUsers.Any(x => x.roleId == 1))
            {
                MessageBox.Show("Bu bölüme giriş yetkiniz yoktur. Lütfen yetkili bir kullanıcı ile giriş yapınız!");
                Dispose();
                return;

            }
            decimal totalPrice=(decimal) ctx.Satis.Sum(x =>x.tutar==null?0:x.tutar);
            dataGridView1.DataSource = ctx.Satis.Select(x => new model
            {
                id = x.id,
                filmAdi=x.filmler.filmAdi,
                musteriAd=x.musteriAd,
                musteriSoyad=x.musteriSoyad,
                tutar=(decimal)x.tutar,
                odemeSekli=x.odemeSekli.odemeTuru,
                Tarih=(DateTime)x.tarih


            }). ToList();
            label2.Text = totalPrice.ToString();
        }
     
    }
    public class model
    {
        public int id { get; set; }
        public string filmAdi { get; set; }
        public DateTime Tarih { get; set; }
        public decimal tutar { get; set; }
        public string musteriAd { get; set; }
        public string musteriSoyad { get; set; }
        public string odemeSekli { get; set; }

    }
}
