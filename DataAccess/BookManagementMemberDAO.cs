using BookObject.Models;
using Microsoft.EntityFrameworkCore;

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

        public List<BookManagementMember> GetAllBook()
        {
            List<BookManagementMember> list;
            IQueryable<BookManagementMember> query;
            try
            {
                using BookManagement2023DbContext context = new BookManagement2023DbContext();
                query = context.BookManagementMembers;
                list = query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }
        public void delete(int memberid)
        {
            try
            {
                using BookManagement2023DbContext context = new BookManagement2023DbContext();
                BookManagementMember member = context.BookManagementMembers.SingleOrDefault(b => b.MemberId == memberid);
                context.BookManagementMembers.Remove(member);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public void create(BookManagementMember member)
        {
            try
            {
                using BookManagement2023DbContext context = new BookManagement2023DbContext();
                context.BookManagementMembers.Add(member);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public void update(BookManagementMember member)
        {
            try
            {
                using BookManagement2023DbContext context = new BookManagement2023DbContext();
                context.Entry<BookManagementMember>(member).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public BookManagementMember GetMemberManagerByID(int memberid)
        {
            using BookManagement2023DbContext context = new BookManagement2023DbContext();
            var member = context.BookManagementMembers.SingleOrDefault(a => a.MemberId == memberid);
            return member;
        }

    }
}