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
    public partial class frmKoltukSecim : Form
    {
        public frmKoltukSecim()
        {
            InitializeComponent();
        }
        BiletContext ctx = new BiletContext();
        private void cmbSaloon_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnKoltukSec_Click(object sender, EventArgs e)
        {
          
        }
        /*
         * KoltukSec fonksiyonu frmKoltukSecim formunun üstündeki tüm butonlar seçilerek eventlerden click eventine
         * KoltukSec ismi verilere oluşturuldu.
         */
        private void KoltukSec(object sender, EventArgs e)
        {

            frmSatisYap myForm;
            //Bu fonksiyondan gelen sender değeri buton olduğunu bildiğimiz için, gelen sender'i butona cast ettik.
            Button btn = (Button)sender;
            //Açık olan formlar içerisinde dönüyoruz.
            foreach (Form form in Application.OpenForms)
            {//Açık olan formlar içerisinde frmSatisYap açık ise if'in içine gir
                if (form.Name == "frmSatisYap")
                {
                    
                    myForm = (frmSatisYap)form;
                    //buton üstünde yazı bizim koltuk adını verir.Bu yüzden buton üzerindeki yazıyı ASLA değiştirmemeniz gerekir.
                    myForm.lblKoltukNo.Text = btn.Text;
                    //koltuk frmSatıs formunda koltuk seç butonuna basınca salon seçimi yaptığımız combobox'tan gelen salon id'sini
                    //lblSalonAdi'nin Tag'ına atmıştık. Şimdi o id'yi kullanmak üzere alıyoruz.
                    int id = Convert.ToInt32(lblSalonAdi.Tag);
                    //koltuk adını alıyoruz.
                    string koltukAdi = btn.Text.ToString();
                    //Burada code firs sorgusu yazıyoruz. Salon id=id olan salonlardan koltuk adı=koltukAdi olan koltuğu getir diyoruz.
                  Koltuk koltuk= ctx.Koltuk.FirstOrDefault(x => x.koltukAdi ==  koltukAdi);
                
                   myForm.lblKoltukNo.Tag = koltuk.id.ToString();
                    //satış formunu gizleyip açıyoruz ki, üzerindeki daha önce yazdığımız veriler kayıp olmasın. Ad,soyad gibi.
                    myForm.Hide();
                    myForm.Show();
                    //Koltuk seçimi formunu dispose ediyoruz. Yani yok ediyoruz.
                    Dispose();
                    
                    //aradığım formu bulduğuma göre döngüden çıkabilirim.
                    break;
                }
              
            }

           

        }
       
        private void frmBiletSecim_Load(object sender, EventArgs e)
        {

            int saloonID = Convert.ToInt32(lblSalonAdi.Tag);
            //salon id'sini lblSalonun Tag'inden alıp bu id ye sahip tüm koltukları listeliyoruz.
            List<Koltuk> koltuk = ctx.Koltuk.Where(x => x.salonunKoltuklari.Any(y => y.salonID == saloonID)).ToList();            //koltuklar içerisinde dönüyoruz
            foreach (var k in koltuk)
            {
                //Formun içindeki tüm elementleri geziyoruz
                foreach (Control item in this.Controls)
                {
                    //Bu item, yani element bir buton ise if içine giriyoruz
                    if (item is Button)
                    {
                        //bu butonun text'i koltukadina eşit ise giriyoruz
                        if (item.Text == k.koltukAdi)
                        {
                            //Koltuk daha önce birine satılmış ise rengini kırmızı,satılmamış ise yeşil yapıyoruz.
                            int seansId = Convert.ToInt32(Tag);
                            bool isExistKoltuk = ctx.Satis.Any(x => x.salonunKoltuklari.koltukID == k.id && x.salonunKoltuklari.salonID == saloonID);
                            bool isExistSeans = ctx.filmler.Any(x => x.filminOturumlari.Any(y => y.oturumId == seansId));
                            if (isExistKoltuk&& isExistSeans)
                            {
                                item.BackColor = Color.Red;
                                item.Enabled = false;
                            }
                            else
                                item.BackColor = Color.SeaGreen;
                            break;
                        }
                    }
                    
                   
                }
            }
         
        }
    }
}
