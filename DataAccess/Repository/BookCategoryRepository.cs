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
    }
}
