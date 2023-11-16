using AutoMapper;
using BookObject.DTO;
using BookObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookObject.Mapper
{
    public class BookConfig
    {
        public static void createMap(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Book, BookDTO>()
                .ForMember(des => des.BookGenreType, act => act.MapFrom(src => src.BookCategory.BookGenreType));

        }
    }
}
