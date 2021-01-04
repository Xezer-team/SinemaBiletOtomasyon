using BiletOtomasyon.Entities;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiletOtomasyon
{
    public partial class frmFilmEkle : Form
    {
        public frmFilmEkle()
        {
            InitializeComponent();
        }
        BiletContext ctx = new BiletContext();
        List<filminOturumlari> filmSeans = new List<filminOturumlari>();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string YoLaL;
            try
            {
                YoLaL = Registry.CurrentUser.GetValue("Yolu").ToString();
            }
            catch
            {
                YoLaL = @"C:\";
            }

            Yeni.Title = "Resim Seçme Penceresi";
            Yeni.Filter = "Resim DosyaLarı (*.gif;*.jpg;*.jpeg;*.png;*.bmp;) | *.gif;*.jpg;*.jpeg;*.png;*.bmp";
            Yeni.InitialDirectory = YoLaL;

            string yoL = null;
            yoL = Yeni.FileName;
            int Numara = yoL.LastIndexOf("\\");
            yoL = yoL.Substring(0, Numara);
            Registry.CurrentUser.SetValue("Yolu", yoL);

            PictureBox p = new PictureBox();
            
            p.Image = Boyutlandir(Image.FromFile(Yeni.FileName));
            pictureBox1.Image = p.Image;

            string ResimAd = Path.GetFileName(Yeni.FileName);
            Random iRnd = new Random((int)999999);
            int Rnd = iRnd.Next();
            string resimYol=  "\\resimler\\" + Rnd + ResimAd;
            p.Image.Save(Application.StartupPath + resimYol);
            try
            {
                filmler film = new filmler();
                
                film.filmAdi = txtFilmName.Text;
                film.filmResim = resimYol;
                film.filmSalonID = Convert.ToInt32(cmbSaloon.SelectedValue);
                film.filmTarziID = Convert.ToInt32(cmbFilmType.SelectedValue);
                film.FilmTurID = Convert.ToInt32(cmbFilmCategory.SelectedValue);
                if (filmSeans.Count>0)
                {
                    film.filminOturumlari = filmSeans;
                }
                else
                {
                    MessageBox.Show("Lütfen En Az Bir Seans Ekleyin");
                    return;
                }
                
                film.status = true;
                film.fiyat = Convert.ToDecimal(txtPrice.Text);
                film.filmAdi = txtFilmName.Text;
                film.filmYil = txtFilmYear.Text;
                ctx.filmler.AddOrUpdate(film);
                int result = ctx.SaveChanges();
                if (result > 0)
                {
                    MessageBox.Show("Film Başarıyla Kayıt Edildi");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Bir Hata Oluştu Lütfen Film Özelliklerini Doğru Girin");
            }


        }

        private void btnPictureAdd_Click(object sender, EventArgs e)
        {
            Yeni.ShowDialog();
            pictureBox1.ImageLocation = Yeni.FileName;
        }
        public Image Boyutlandir(Image img)
        {
            int son_en = 0;
            int son_boy = 0;
            double x_oran, y_oran, max_en, max_boy;
            int originalW = img.Width;
            int originalH = img.Height;
            if (originalW >= originalH)
            {
                max_en = 132;//Buraları Kendine göre ayarlarsın
                max_boy = 132;//Buraları Kendine göre ayarlarsın
            }
            else
            {
                max_en = 132;//Buraları Kendine göre ayarlarsın
                max_boy = 132;//Buraları Kendine göre ayarlarsın
            }

            x_oran = (max_en / originalW);
            y_oran = (max_boy / originalH);


            if (originalW <= max_en)
            {
                if (originalH <= max_boy)
                {
                    son_en = originalW;
                    son_boy = originalH;
                }
            }
            else if ((x_oran * originalH) < max_boy)
            {
                son_en = (int)max_en;
                son_boy = (int)(x_oran * originalH);
            }
            else
            {
                son_en = (int)(y_oran * originalW);
                son_boy = (int)max_boy;
            }
            Bitmap bmp = new Bitmap(son_en, son_boy);
            Graphics graphic = Graphics.FromImage((Image)bmp);
            graphic.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphic.DrawImage(img, 0, 0, son_en, son_boy);
            graphic.Dispose();
            return (Image)bmp;
        }

        private void frmFilmEkle_Load(object sender, EventArgs e)
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
            cmbFilmCategory.DataSource = ctx.filmTurleri.ToList();
            cmbFilmCategory.DisplayMember = "turAdi";
            cmbFilmCategory.ValueMember = "id";

            cmbFilmSeason.DataSource = ctx.oturumlar.ToList();
            cmbFilmSeason.DisplayMember = "oturum";
            cmbFilmSeason.ValueMember = "id";

            cmbFilmType.DataSource = ctx.filmTarzi.ToList();
            cmbFilmType.DisplayMember = "tarzAdi";
            cmbFilmType.ValueMember = "id";

            cmbSaloon.DataSource = ctx.Salon.ToList();
            cmbSaloon.DisplayMember = "SalonAdı";
            cmbSaloon.ValueMember = "id";
        }

        private void btnSeansAdd_Click(object sender, EventArgs e)
        {
            filminOturumlari seans = new filminOturumlari();
            seans.filmId = Convert.ToInt32(Tag);
            seans.oturumId = Convert.ToInt32(cmbFilmSeason.SelectedValue);
            filmSeans.Add(seans);
            listBox1.Items.Add(ctx.oturumlar.FirstOrDefault(x => x.id == seans.oturumId).oturum);

        }
    }
}
