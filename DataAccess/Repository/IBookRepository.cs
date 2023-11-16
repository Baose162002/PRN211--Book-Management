using BookObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IBookRepository
    {
        public List<Book> GetAllBook();
        public void delete(int bookid);
        public void insert(Book book);
        public void update(Book book);
        public Book GetBookById(int bookid);
        public List<Book> SearchBooks(string keyword);
    }
}
