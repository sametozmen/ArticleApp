using ArticleApp.DataAccess.Abstract;
using ArticleApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleApp.DataAccess.Concrete
{
    class EFCategoryDAL : EfCoreGenericRepository<Category, ArticleContext>, ICategoryDAL
    {
    }
}
