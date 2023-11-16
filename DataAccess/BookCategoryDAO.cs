using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookObject.Models;
namespace DataAccess
{
    public class BookCategoryDAO
    {
        public BookCategoryDAO() { }
        public static BookCategoryDAO instance;
        public static BookCategoryDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BookCategoryDAO();
                }
                return instance;
            }
        }
        public List<BookCategory> GetBookCategories()
        {
            List<BookCategory> list;
            IQueryable<BookCategory> query;
            try
            {
                using BookManagement2023DbContext context = new BookManagement2023DbContext();
                query = context.BookCategories;
                list = query.ToList();
            }catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return list;
        }

        public void create(BookCategory bookcategory)
        {
            try
            {
                using BookManagement2023DbContext context = new BookManagement2023DbContext();
                context.BookCategories.Add(bookcategory);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public void update(BookCategory bookcategory)
        {
            try
            {
                using BookManagement2023DbContext context = new BookManagement2023DbContext();
                context.Entry<BookCategory>(bookcategory).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public BookCategory GetBookCategoryById(int bookcategoryid)
        {
            using BookManagement2023DbContext context = new BookManagement2023DbContext();
            var bookcategory = context.BookCategories.SingleOrDefault(a => a.BookCategoryId == bookcategoryid);
            return bookcategory;
        }
        public void delete(int bookcategoryid)
        {
            try
            {
                using BookManagement2023DbContext context = new BookManagement2023DbContext();
                BookCategory bookcategory = context.BookCategories.SingleOrDefault(b => b.BookCategoryId == bookcategoryid);
                context.BookCategories.Remove(bookcategory);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

    }
}
