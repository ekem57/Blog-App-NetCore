﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IBlogDal : IGenericDal<Blog>
    {
        List<Blog> GetListWithCategory();
        List<Blog> ListAllBlog();
        void BlogAdd(Blog blog);
        void BlogDelete(Blog blog);
        void UpdateBlog(Blog blog);
        Blog GetById(int id);
    }
}
