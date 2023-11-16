using BookObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IBookCategoryRepository
    {
        public List<BookCategory> GetBookCategories();
        public void create(BookCategory bookcategory);
        public void update(BookCategory bookcategory);
        public void delete(int bookcategoryid);
        public BookCategory GetBookCategoryById(int bookcategoryid);
    }
}
