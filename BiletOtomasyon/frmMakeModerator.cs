using BiletOtomasyon.Entities;
using BiletOtomasyon.models;
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
    public partial class frmMakeModerator : Form
    {
        public frmMakeModerator()
        {
            InitializeComponent();
        }
        BiletContext ctx = new BiletContext();
        List<userModel> list()
        {
            var userList = ctx.users.Where(x => x.roleOfUsers.Any(y => y.roleId == 2)).Select(z => new userModel
            {
                email = z.email,
                id = z.id,
                name = z.name,
                rolName = z.roleOfUsers.FirstOrDefault(x => x.roles.id == 2).roles.roleName,
                surname = z.surname,
                userName = z.surname
            }
         ).ToList();
            return userList;
        }
        private void frmMakeModerator_Load(object sender, EventArgs e)
        {
            if (Tag == null)
            {
                MessageBox.Show("Bu bölüme giriş yetkiniz yoktur. Lütfen yetkili bir kullanıcı ile giriş yapınız!");
                Dispose();
                return;
            }
            List<roleOfUsers> roleOfUsers = (List<roleOfUsers>)Tag;
            if (!roleOfUsers.Any(x => x.roleId == 1))
            {
                MessageBox.Show("Bu bölüme giriş yetkiniz yoktur. Lütfen yetkili bir kullanıcı ile giriş yapınız!");
                Dispose();
                return;

            }
            dataGridMod.DataSource = list();
        }

        private void dataGridMod_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var id = Convert.ToInt32(dataGridMod.CurrentRow.Cells["id"].Value);
            DialogResult isOk = MessageBox.Show("Bu Kullanıcıyı Moderatör Yapmak İstediğinizden Emin misiniz ?", "Uyarı",  MessageBoxButtons.YesNo);
            if (DialogResult.Yes==isOk)
            {
                users user = ctx.users.FirstOrDefault(x => x.id == id);
                if (user != null)
                {
                    try
                    {
                        if (user.roleOfUsers.Any(x => x.roleId == 1))
                        {
                            MessageBox.Show("Bu Kullanıcı Zaten Moderatördür!");
                            return;
                        }
                        user.roleOfUsers.Add(new roleOfUsers { roleId = 1, userId = user.id });
                        ctx.users.AddOrUpdate(user);
                        int result = ctx.SaveChanges();
                        if (result > 0)
                        {
                            MessageBox.Show("Kullanıcı Moderatör Yapıldı");
                            dataGridMod.DataSource = list();
                        }
                        else
                        {
                            MessageBox.Show("Bir Hata Meydana Geldi Lütfen Tekrar Deneyiniz");
                        }
                    }
                    catch
                    {

                        MessageBox.Show("Bir Hata Meydana Geldi Lütfen Tekrar Deneyiniz");
                    }
                }
            }
        }
    }
}
