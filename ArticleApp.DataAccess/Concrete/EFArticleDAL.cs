using ArticleApp.DataAccess.Abstract;
using ArticleApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArticleApp.DataAccess.Concrete
{
    public class EFArticleDAL : EfCoreGenericRepository<Article, ArticleContext>, IArticleDAL
    {
        public List<Article> Search(string search)
        {
            using (var db = new ArticleContext())
            {
                var article = db.Articles.Where(i => EF.Functions.Like(i.ArticleHeader.ToLower(), "%" + search.ToLower() + "%")).ToList();
                return article;


            }
        }
    }
}
