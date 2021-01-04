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
    public partial class frmFilmList : Form
    {
        public frmFilmList()
        {
            InitializeComponent();
        }
        BiletContext ctx = new BiletContext();

        private void frmFilmList_Load(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();

            DataGridViewTextBoxColumn filmName = new DataGridViewTextBoxColumn();

            DataGridViewTextBoxColumn filmCategory = new DataGridViewTextBoxColumn();

            DataGridViewTextBoxColumn filmType = new DataGridViewTextBoxColumn();

            DataGridViewTextBoxColumn filmYear = new DataGridViewTextBoxColumn();
            DataGridViewImageColumn filmPicture = new DataGridViewImageColumn();
            DataGridViewTextBoxColumn filmPrice = new DataGridViewTextBoxColumn();
            dataGridFilmList.Columns.Add(filmPicture);
            dataGridFilmList.Columns.Add(id);
            dataGridFilmList.Columns.Add(filmName);
            dataGridFilmList.Columns.Add(filmCategory);
            dataGridFilmList.Columns.Add(filmType);
            dataGridFilmList.Columns.Add(filmYear);          
            dataGridFilmList.Columns.Add(filmPrice);
            id.Name = "id";
            id.HeaderText = "Film Kodu";
            filmName.HeaderText = "Film Adı";
            filmCategory.HeaderText = "Kategori";
            filmType.HeaderText = "Film Tipi";
            filmYear.HeaderText = "Film Yılı";
            filmPicture.HeaderText = "Resim";
            filmPrice.HeaderText="Fiyat";
            List<filmler> films = ctx.filmler.ToList();
          
            for (int i = 0; i < films.Count; i++)
            {

            
           
                

                dataGridFilmList.Rows[i].Height =
100;
                string yol = Application.StartupPath + films[i].filmResim;
                dataGridFilmList.Rows[i].Cells[0].Value = Image. FromFile(yol.ToString());
                dataGridFilmList.Rows[i].Cells[1].Value = films[i].id.ToString();
               
                dataGridFilmList.Rows[i].Cells[2].Value = films[i].filmAdi.ToString();
                dataGridFilmList.Rows[i].Cells[3].Value = films[i].filmTurleri.turAdi.ToString();
                dataGridFilmList.Rows[i].Cells[4].Value = films[i].filmTarzi.tarzAdi.ToString();
                dataGridFilmList.Rows[i].Cells[5].Value = films[i].filmYil.ToString();
                dataGridFilmList.Rows[i].Cells[6].Value = films[i].fiyat.ToString();
              

            }
        }

        private void dataGridFilmList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var filmId =Convert.ToInt32(dataGridFilmList.CurrentRow.Cells["id"].Value);
            frmSatisYap sat = new frmSatisYap();
            sat.lblPrice.Text = ctx.filmler.FirstOrDefault(x => x.id == filmId).fiyat.ToString();
            sat.txtFilmName.Text = ctx.filmler.FirstOrDefault(x => x.id == filmId).filmAdi.ToString();
            sat.Tag = filmId;
            sat.Show();
        }
    }
}
