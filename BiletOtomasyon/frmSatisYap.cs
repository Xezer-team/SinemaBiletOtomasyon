using BiletOtomasyon.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiletOtomasyon
{
    public partial class frmSatisYap : Form
    {
        public frmSatisYap()
        {
            InitializeComponent();
        }
        BiletContext ctx = new BiletContext();

        private void cmbSaloon_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void btnKoltukSec_Click(object sender, EventArgs e)
        {
            //Salon seçimi combobox'ından gelen salon id'sini hem btnKoltukSec'in tag'ına hem de koltuk seçimi formu içindeki
            // label'a atıyoruz.Seçim yapılmamışsa Hata verdiriyoruz.
            int id = Convert.ToInt32(cmbSaloon.SelectedValue);
            int seansId = Convert.ToInt32(cmbSeans.SelectedValue);
            frmKoltukSecim frmKoltukSec = new frmKoltukSecim();
            frmKoltukSec.Tag = seansId;
            btnKoltukSec.Tag = id;
            if (btnKoltukSec.Tag == null)
            {
                MessageBox.Show("Lütfen Önce Bir Salon Seçimi Yapınız !");
            }
            else if (frmKoltukSec == null)
            {
                MessageBox.Show("Lütfen Önce Bir Seans Seçimi Yapınız !");
            }
            else
            {


                if (frmKoltukSec != null)
                {
                    frmKoltukSec.lblSalonAdi.Tag = id;
                    frmKoltukSec.lblSalonAdi.Text = ctx.Salon.FirstOrDefault(x=>x.id== id).SalonAdı + " " + ctx.oturumlar.FirstOrDefault(x => x.id == seansId).oturum + " Seans" + " Koltuk Seçimi";

                    frmKoltukSec.Show();
                }


            }
        }

        private void frmSatisYap_Load(object sender, EventArgs e)
        {

            if (Tag != null)
            {
                int filmId = Convert.ToInt32(Tag);
                var saloons = ctx.Salon.Where(x => x.filmler.Any(y => y.id == filmId)).ToList();

                //Veritabanından odeme seklini çekip combobox'a atıyoruz..
                cmbOdemeSekli.DataSource = ctx.odemeSekli.ToList();
                cmbOdemeSekli.ValueMember = "id";
                cmbOdemeSekli.DisplayMember = "odemeTuru";
                cmbSaloon.DataSource = saloons;
                cmbSaloon.ValueMember = "id";
                cmbSaloon.DisplayMember = "SalonAdı";
                cmbSeans.DataSource = ctx.oturumlar.Where(x => x.filminOturumlari.Any(y => y.filmId == filmId)).ToList();
                cmbSeans.ValueMember = "id";
                cmbSeans.DisplayMember = "oturum";
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            //Veritabanına satış işlemi, satılan koltuğun satıldığını ve satış fişini yazdırmayı yapıyoruz.
            int salonId = Convert.ToInt32(cmbSaloon.SelectedValue);
            int koltukId = Convert.ToInt32(lblKoltukNo.Tag);
     
            salonunKoltuklari salonKoltuk = ctx.salonunKoltuklari.FirstOrDefault(x => x.koltukID == koltukId && x.salonID == salonId);
            if (Tag == null)
            {
                
                MessageBox.Show("Lütfen öncelikle bir film seçiniz!");
                return;
            }
            if (salonKoltuk == null)
            {
                MessageBox.Show("Seçilen salona ait böyle bir koltuk bulunamadı!");
                return;
            }
            if (salonKoltuk.status == true)
            {
                MessageBox.Show("Seçilen koltuk zaten satılmıştır!");
                return;
            }
            Satis satis = new Satis();
            satis.musteriAd = txtName.Text;
            satis.musteriSoyad = txtSurname.Text;
            satis.tarih = DateTime.Now;
            satis.tutar = Convert.ToDecimal(lblPrice.Text);
            satis.odemeSekliID = Convert.ToInt32(cmbOdemeSekli.SelectedValue);
            satis.filmID = Convert.ToInt32(Tag); 


            satis.salonKoltukID = salonKoltuk.id;
            ctx.Satis.AddOrUpdate(satis);
            salonKoltuk.status = true;
            ctx.salonunKoltuklari.AddOrUpdate(salonKoltuk);

            int sonuc = ctx.SaveChanges();

            if (sonuc > 0)
            {
                MessageBox.Show("Bilet Satışı Gerçekleşti ", "Başarılı");
                var frmBilet = new frmBilet();
                frmBilet.lblAd.Text = satis.musteriAd.ToString();
                frmBilet.lblSoyad.Text = satis.musteriSoyad.ToString();
                frmBilet.lblKoltuk.Text = satis.salonunKoltuklari.Koltuk.koltukAdi;
                frmBilet.lblSalonAd.Text = satis.salonunKoltuklari.Salon.SalonAdı;
                frmBilet.lblFiyat.Text = satis.tutar.ToString();
                frmBilet.lblFilmName.Text = txtFilmName.Text.ToString();
                frmBilet.Show();

            }
        }
    }
}
