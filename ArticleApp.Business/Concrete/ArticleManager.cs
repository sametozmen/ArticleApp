using ArticleApp.Business.Abstract;
using ArticleApp.DataAccess.Abstract;
using ArticleApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleApp.Business.Concrete
{
    public class ArticleManager : IArticleServices
    {
        private IArticleDAL _ArticleDal;
        public ArticleManager(IArticleDAL ArticleDal)
        {
            _ArticleDal = ArticleDal;
        }

        public void Add(Article article)
        {
            _ArticleDal.Create(article);
        }

        public void Delete(Article article)
        {
            _ArticleDal.Delete(article);
        }

        public List<Article> GetAll()
        {
            return _ArticleDal.GetAll();
        }

        public Article GetById(int artID)
        {
            return _ArticleDal.GetById(artID);
        }

        public List<Article> Search(string search)
        {
            throw new NotImplementedException();
        }

        public void Update(Article article)
        {
            _ArticleDal.Update(article);
        }
    }
}
