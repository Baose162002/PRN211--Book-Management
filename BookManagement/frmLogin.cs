using BookObject.Models;
using DataAccess.Repository;
namespace BookManagement_TranQuocBao
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private BookManagementMemberRepository memberRepository = new BookManagementMemberRepository();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var authenStaff = authencation(txtEmail.Text, txtPassword.Text);
            if (authenStaff == null)
            {
                MessageBox.Show("Login fail");
            }
            else
            {

                this.Hide();
                frmBookManagement frmbookmanagement = new frmBookManagement();
                frmbookmanagement.ShowDialog();
                this.Close();
            }


        }

        private BookManagementMember authencation(string email, string password)
        {
            return memberRepository.FindEmailAndPassword(email, password);
        }


    }
}