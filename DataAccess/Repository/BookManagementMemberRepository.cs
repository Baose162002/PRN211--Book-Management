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
    }
}
