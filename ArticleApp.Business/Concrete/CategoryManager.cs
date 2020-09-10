using ArticleApp.Business.Abstract;
using ArticleApp.DataAccess.Abstract;
using ArticleApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleApp.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDAL _categoryDAL;
        public CategoryManager(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
        }
        public List<Category> GetAll()
        {
            return _categoryDAL.GetAll();
        }
    }
}
