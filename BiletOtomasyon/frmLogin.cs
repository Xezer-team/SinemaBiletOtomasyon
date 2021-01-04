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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        BiletContext ctx = new BiletContext();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text.Trim())||string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz !");
                return;
            }
            users user = ctx.users.FirstOrDefault(x => x.email == txtEmail.Text && x.password == txtPassword.Text);
            if (user!=null)
            {
                frmAnaSayfa anasayfa = new frmAnaSayfa();
                anasayfa.Tag = user.roleOfUsers.ToList(); ;
                anasayfa.Show();
                Hide();
            }
            else
                MessageBox.Show("Kullanıcı Adı ya da Şifre Yanlıştır !");

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister reg = new frmRegister();
            reg.Show();
            Hide();
        }
    }
}
