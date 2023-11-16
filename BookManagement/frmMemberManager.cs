using BookObject.Models;
using DataAccess.Repository;
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
    public partial class frmMemberManager : Form
    {
        public frmMemberManager()
        {
            InitializeComponent();
        }
        private BookManagementMemberRepository bookmemberRepository = new BookManagementMemberRepository();

        private BindingSource memberSource;
        private void frmMemberManager_Load(object sender, EventArgs e)
        {
            LoadMember();
        }
        public void LoadMember()
        {
            memberSource = new BindingSource();
            var list = bookmemberRepository.GetAllBook();
            memberSource.DataSource = list;
            txtMemberID.DataBindings.Clear();
            txtPassword.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtFullName.DataBindings.Clear();
            txtMemberRole.DataBindings.Clear();

            txtMemberID.DataBindings.Add("Text", memberSource, "MemberId");
            txtPassword.DataBindings.Add("Text", memberSource, "Password");
            txtEmail.DataBindings.Add("Text", memberSource, "Email");
            txtFullName.DataBindings.Add("Text", memberSource, "FullName");
            txtMemberRole.DataBindings.Add("Text", memberSource, "MemberRole");

            dgvMember.DataSource = null;
            dgvMember.DataSource = memberSource;

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadMember();
        }
        public BookManagementMember GetMemberManager()
        {
            BookManagementMember bookmanagementmember = null;
            try
            {
                int index = dgvMember.CurrentCell.RowIndex;
                var dummy = (BookManagementMember)dgvMember.Rows[index].DataBoundItem;
                bookmanagementmember = bookmemberRepository.GetMemberManagerByID(dummy.MemberId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return bookmanagementmember;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you ready want to delete", "Member Manager", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (d == DialogResult.OK)
            {
                bookmemberRepository.delete(int.Parse(txtMemberID.Text));
                LoadMember();
            }
              
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmMemberDetail frmMemberManager = new frmMemberDetail
            {
                Text = "Add Member",
                InsertOrUpdate = false,
                bookmemberRepository = bookmemberRepository,
            };

            // Use frmMemberManager instead of frmMemberDetail
            if (frmMemberManager.ShowDialog() == DialogResult.OK)
            {
                LoadMember();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmMemberDetail frmMemberManager = new frmMemberDetail
            {
                Text = "Update Book Category",
                InsertOrUpdate = true,
                bookManagementMemberInfor = GetMemberManager(),

                bookmemberRepository = bookmemberRepository,
            };
            if (frmMemberManager.ShowDialog() == DialogResult.OK)
            {
                LoadMember();
            }
        }
    }
}
