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
    public partial class frmSalonEkle : Form
    {
        public frmSalonEkle()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BiletContext ctx = new BiletContext();
            bool isExistTheSaloon = ctx.Salon.Any(x => x.SalonAdı == txtSaloonName.Text);
            if (isExistTheSaloon)
            {
                MessageBox.Show("Bu isimde bir salon zaten var!");
            }
            else
            {
                Salon salon = new Salon();
                salon.SalonAdı = txtSaloonName.Text;
                foreach (var koltuk in ctx.Koltuk.ToList())
                {
                    salon.salonunKoltuklari.Add(new salonunKoltuklari { koltukID = koltuk.id, salonID = salon.id });
                }
                ctx.Salon.AddOrUpdate(salon);
                int result = ctx.SaveChanges();
                if (result>0)
                {
                    MessageBox.Show("Salon Başarıyla Eklendi");
                }
                
            }

        }
    }
}
