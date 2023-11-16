using BookManagement_TranQuocBao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagement
{
    public partial class frmMainAdmin : Form
    {
        public frmMainAdmin()
        {
            InitializeComponent();
        }

        private void btnMember_Click(object sender, EventArgs e)
        {

            frmMemberManager frmMemberManager = new frmMemberManager();
            frmMemberManager.ShowDialog();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {

            frmBookManagement frmBookManagement = new frmBookManagement();
            frmBookManagement.ShowDialog();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {

            frmBookCategory frmBookCategory = new frmBookCategory();
            frmBookCategory.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
