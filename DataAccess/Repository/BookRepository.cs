using BookObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class BookRepository : IBookRepository
    {
        public List<Book> GetAllBook()
        {
            return BookDAO.Instance.GetAllBook();
        }
        public void delete(int bookid)
        {
            BookDAO.Instance.delete(bookid);
        }
        public void insert(Book book)
        {
            BookDAO.Instance.create(book);
        }
        public void update(Book book)
        {
            BookDAO.Instance.update(book);
        }
        public Book GetBookById(int bookid)
        {
           return BookDAO.Instance.GetBookById(bookid);
        }
        public List<Book> SearchBooks(string keyword)
        {
            return BookDAO.Instance.SearchBooks(keyword);
        }

    }
}
