using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookObject.Models;
namespace DataAccess.Repository
{
    public class BookManagementMemberRepository : IBookManagementMemberRepository
    {
        public BookManagementMember FindEmailAndPassword(string email, string password)
        {
            return BookManagementMemberDAO.Instance.FindEmailAndPassword(email, password);
        }
        public List<BookManagementMember> GetAllBook()
        {
            return BookManagementMemberDAO.Instance.GetAllBook();
        }
        public void delete(int memberid)
        {
            BookManagementMemberDAO.Instance.delete(memberid);
        }
        public void create(BookManagementMember member)
        {
            BookManagementMemberDAO.Instance.create(member);
        }
        public void update(BookManagementMember member)
        {
            BookManagementMemberDAO.Instance.update(member);
        }
        public BookManagementMember GetMemberManagerByID(int memberid)
        {
            return BookManagementMemberDAO.Instance.GetMemberManagerByID(memberid);
        }
    }
}
