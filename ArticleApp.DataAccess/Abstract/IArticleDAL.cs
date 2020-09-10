using ArticleApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleApp.DataAccess.Abstract
{
    public interface IArticleDAL:IRepository<Article>
    {
        List<Article> Search(string search);
    }
}
