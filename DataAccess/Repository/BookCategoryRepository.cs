using BookObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class BookCategoryRepository : IBookCategoryRepository
    {
        public List<BookCategory> GetBookCategories()
        {
            return BookCategoryDAO.Instance.GetBookCategories();
        }
        public void create(BookCategory bookcategory)
        {
            BookCategoryDAO.Instance.create(bookcategory);
        }
        public void update(BookCategory bookcategory)
        {
            BookCategoryDAO.instance.update(bookcategory);
        }
        public void delete(int bookcategoryid)
        {
            BookCategoryDAO.Instance.delete(bookcategoryid);
        }
        public BookCategory GetBookCategoryById(int bookcategoryid)
        {
            return BookCategoryDAO.Instance.GetBookCategoryById(bookcategoryid);
        }
    }
}
