using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookObject.Models;
using DataAccess.Repository;
namespace DataAccess
{
    public class BookDAO
    {
        public BookDAO() { }
        private static BookDAO instance;
        public static BookDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BookDAO();
                }
                return instance;
            }
        }
        public List<Book> GetAllBook()
        {
            List<Book> list;
            IQueryable<Book> query;
            try
            {
                using BookManagement2023DbContext context = new BookManagement2023DbContext(); 
                query = context.Books;
                list = query.ToList();
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }
        public void delete(int bookid)
        {
            try
            {
                using BookManagement2023DbContext context = new BookManagement2023DbContext();
                Book book = context.Books.SingleOrDefault(b => b.BookId ==  bookid);
                context.Books.Remove(book);
                context.SaveChanges();
            }catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public void create(Book book)
        {
            try
            {
                using BookManagement2023DbContext context = new BookManagement2023DbContext();
                context.Books.Add(book);
                context.SaveChanges();
            }catch (Exception ex)
            {
                throw new Exception (ex.Message, ex);
            }
        }

        public void update(Book book)
        {
            try
            {
                using BookManagement2023DbContext context = new BookManagement2023DbContext();
                context.Entry<Book>(book).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
            }catch  (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Book GetBookById(int bookid)
        {
            using BookManagement2023DbContext context = new BookManagement2023DbContext();
            var book = context.Books.SingleOrDefault(a => a.BookId == bookid);
            return book;
        }
        public List<Book> SearchBooks(string keyword)
        {
            List<Book> resultList;
            try
            {
                using (BookManagement2023DbContext context = new BookManagement2023DbContext())
                {
                    resultList = context.Books
                        .Where(b => b.BookName.Contains(keyword) || b.Author.Contains(keyword))
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return resultList;
        }


    }
}
