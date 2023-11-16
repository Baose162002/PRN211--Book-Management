using BookObject.Models;
namespace DataAccess
{
    public class BookManagementMemberDAO
    {
        private BookManagementMemberDAO() { }
        private static BookManagementMemberDAO instance;

        public static BookManagementMemberDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BookManagementMemberDAO();
                }
                return instance;
            }
        }
        public BookManagementMember FindEmailAndPassword(string email,string password) 
        {
            BookManagementMember bookManagementMember = null;
            try
            {
                using BookManagement2023DbContext context = new BookManagement2023DbContext();
                bookManagementMember = context.BookManagementMembers.SingleOrDefault(b => b.Email == email && b.Password == password);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return bookManagementMember;
        }


    }
}