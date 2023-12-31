﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookObject.DTO
{
    public class BookDTO
    {
        public int BookId { get; set; }

        public string BookName { get; set; } = null!;

        public string Description { get; set; } = null!;

        public DateTime ReleaseDate { get; set; }

        public int Quantity { get; set; }

        public double Price { get; set; }

        public int BookCategoryId { get; set; }

        public string Author { get; set; } = null!;

        public string BookGenreType { get; set; } = null!;
    }
}
