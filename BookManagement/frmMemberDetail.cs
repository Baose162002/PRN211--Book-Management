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
    public partial class frmMemberDetail : Form
    {
        public frmMemberDetail()
        {
            InitializeComponent();
        }
        public IBookManagementMemberRepository bookmemberRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public BookManagementMember bookManagementMemberInfor { get; set; }
        private void ClearText()
        {
            txtMemberID.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtFullName.Text = string.Empty;
            txtMemberRole.Text = string.Empty;

        }
        private void MemberDetail_Load(object sender, EventArgs e)
        {
            txtMemberID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)
            {
                txtMemberID.Text = bookManagementMemberInfor.MemberId.ToString();
                txtPassword.Text = bookManagementMemberInfor.Password;
                txtEmail.Text = bookManagementMemberInfor.Email;
                txtFullName.Text = bookManagementMemberInfor.FullName;
                txtMemberRole.Text = bookManagementMemberInfor.MemberRole.ToString();



            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtMemberID.Text) ||
               string.IsNullOrEmpty(txtPassword.Text) ||
               string.IsNullOrEmpty(txtEmail.Text) ||
                    string.IsNullOrEmpty(txtFullName.Text) ||
                string.IsNullOrEmpty(txtMemberRole.Text))

            {
                MessageBox.Show("Required all fields");
                return;

            }
            try
            {


                var bookmamangementmember = new BookManagementMember()
                {
                    MemberId = int.Parse(txtMemberID.Text),
                    Password = txtPassword.Text,
                    Email = txtEmail.Text,
                    FullName = txtFullName.Text,
                    MemberRole = int.Parse(txtMemberRole.Text)

                };
                if (InsertOrUpdate)
                {
                    bookmemberRepository.update(bookmamangementmember);
                    MessageBox.Show("Update successful");
                }
                else
                {
                    bookmemberRepository.create(bookmamangementmember);
                    MessageBox.Show("Add successful");
                    ClearText();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)=> Close();

    }
}
