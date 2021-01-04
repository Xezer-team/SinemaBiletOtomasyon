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
    public partial class frmGiveUpRole : Form
    {
        public frmGiveUpRole()
        {
            InitializeComponent();
        }
        BiletContext ctx = new BiletContext();
       List< userModel> list()
        {
            var userList = ctx.users.Where(x => x.roleOfUsers.Any(y => y.roleId == 1)).Select(z => new userModel
            {
                email = z.email,
                id = z.id,
                name = z.name,
                rolName = z.roleOfUsers.FirstOrDefault(x => x.roles.id == 1).roles.roleName,
                surname = z.surname,
                userName = z.surname
            }
      ).ToList();
            return userList;
        }
        private void frmGiveUpRole_Load(object sender, EventArgs e)
        {
            if (Tag==null)
            {
                MessageBox.Show("Bu bölüme giriş yetkiniz yoktur. Lütfen yetkili bir kullanıcı ile giriş yapınız!");
                Dispose();
                return;
            }
            List<roleOfUsers> roleOfUsers = (List<roleOfUsers>)Tag;
            if (!roleOfUsers.Any(x=>x.roleId==1))
            {
                MessageBox.Show("Bu bölüme giriş yetkiniz yoktur. Lütfen yetkili bir kullanıcı ile giriş yapınız!");
                Dispose();
                return;

            }
            dataGridModeList.DataSource = list();

        }

        private void dataGridModeList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var id = Convert.ToInt32(dataGridModeList.CurrentRow.Cells["id"].Value);
            DialogResult isOk = MessageBox.Show("Bu Kullanıcının Moderatörlük Rütbesini Almak İstediğinizden Emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo);
            if (DialogResult.Yes == isOk)
            {
                users user = ctx.users.FirstOrDefault(x => x.id == id);
                if (user != null)
                {
                    try
                    {
                        if (!user.roleOfUsers.Any(x => x.roleId == 1))
                        {
                            MessageBox.Show("Bu Kullanıcı Zaten Moderatör Değildir!");
                            return;
                        }
                        var giveUp = ctx.roleOfUsers.FirstOrDefault(x => x.roleId == 1 && x.userId == user.id);
                        ctx.roleOfUsers.Remove(giveUp);

                        int result = ctx.SaveChanges();
                        if (result > 0)
                        {
                            MessageBox.Show("Kullanıcının Moderatörlüğü Alındı");
                            dataGridModeList.DataSource = list();

                        }
                        else
                        {
                            MessageBox.Show("Bir Hata Meydana Geldi Lütfen Tekrar Deneyiniz");
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Bir Hata Meydana Geldi Lütfen Tekrar Deneyiniz");
                    }
                }
            }
        }
    }
}
