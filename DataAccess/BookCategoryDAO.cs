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
    }
}
