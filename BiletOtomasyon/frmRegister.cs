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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }
        BiletContext ctx = new BiletContext();
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text.Trim())|| string.IsNullOrEmpty(txtSurname.Text.Trim()) || string.IsNullOrEmpty(txtEmail.Text.Trim()) || string.IsNullOrEmpty(txtPassword.Text.Trim()) || string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                MessageBox.Show("Lütfen Tüm Alanları Eksiksiz Doldurunuz !");
                return;
            }
            if (ctx.users.Any(x=>x.email==txtEmail.Text||x.username==txtUserName.Text))
            {
                MessageBox.Show("Böyle Bir Kullanıcı Adı veya Email İle Kayıt Olan Kullanıcı Zaten Mevcuttur");
                return;
            }
            users user = new users();
            user.name = txtName.Text;
            user.surname = txtSurname.Text;
            user.email = txtEmail.Text;
            user.password = txtPassword.Text;
            user.username = txtUserName.Text;
            user.roleOfUsers.Add(new roleOfUsers { userId = user.id, roleId = 2 });//standart üye
            ctx.users.AddOrUpdate(user);
            int result = ctx.SaveChanges();
            if (result > 0)
            {
                MessageBox.Show("Kullanıcı Başarıyla Kayıt Edildi");
                frmAnaSayfa anasayfa = new frmAnaSayfa();
                anasayfa.Tag = user.roleOfUsers.ToList() ;
                anasayfa.Show();
                Hide();
            }
            else
                MessageBox.Show("Kullanıcı Ekleme Sırasında Bir Hata Meydana Geldi");
        }
    }
}
