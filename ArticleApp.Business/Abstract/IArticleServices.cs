using ArticleApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleApp.Business.Abstract
{
    public interface IArticleServices
    {
        List<Article> Search(string search);
        List<Article> GetAll();
        Article GetById(int artID);
        void Add(Article article);
        void Delete(Article article);
        void Update(Article article);

    }
}
