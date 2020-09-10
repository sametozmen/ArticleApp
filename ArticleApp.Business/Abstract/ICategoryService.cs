using ArticleApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleApp.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        

    }
}
