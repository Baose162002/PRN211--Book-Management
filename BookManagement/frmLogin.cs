using BookManagement;
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
                if (authenStaff.MemberRole == 1) // Assuming 1 is Admin
                {
                    // Admin
                    this.Hide();
                    frmMainAdmin frmMain = new frmMainAdmin();
                    frmMain.ShowDialog();
                    this.Close();
                }
                else if (authenStaff.MemberRole == 2) // Assuming 2 is Staff
                {
                    // Staff
                    this.Hide();
                    frmBookManagement frmbookmanagement = new frmBookManagement();

                    // Set permissions based on role
                    frmbookmanagement.EnableCreateAndUpdate();

                    frmbookmanagement.ShowDialog();
                    this.Close();
                }
                else if (authenStaff.MemberRole == 3) // Assuming 3 is Member
                {
                    // Member
                    this.Hide();
                    frmBookManagement frmbookmanagement = new frmBookManagement();

                    // Set permissions based on role
                    frmbookmanagement.EnableViewOnly();

                    frmbookmanagement.ShowDialog();
                    this.Close();
                }
            }


        }
        private BookManagementMember authencation(string email, string password)
        {
            return memberRepository.FindEmailAndPassword(email, password);
        }

    }
}