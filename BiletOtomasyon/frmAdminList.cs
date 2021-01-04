using BiletOtomasyon.Entities;
using BiletOtomasyon.models;
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
    public partial class frmAdminList : Form
    {
        public frmAdminList()
        {
            InitializeComponent();
        }
        BiletContext ctx = new BiletContext();
        private void frmAdminList_Load(object sender, EventArgs e)
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
            dataGridAdminList.DataSource = userList;
        }
    }
}
