﻿using BookObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IBookManagementMemberRepository
    {
        public BookManagementMember FindEmailAndPassword(string email, string password);
        public List<BookManagementMember> GetAllBook();
        public void delete(int memberid);
        public void create(BookManagementMember member);
        public BookManagementMember GetMemberManagerByID(int memberid);
        public void update(BookManagementMember member);
       
    }
}
