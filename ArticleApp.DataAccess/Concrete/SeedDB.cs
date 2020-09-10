using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ArticleApp.Entities;
using System.Linq;

namespace ArticleApp.DataAccess.Concrete
{
    public static class SeedDB
    {
        public static void Seed()
        {
            var context = new ArticleContext();

            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Categories.Count() == 0)
                {
                    context.Categories.AddRange(Categories);
                }

                if (context.Articles.Count() == 0)
                {
                    context.Articles.AddRange(Articles);
                    
                }
                if (context.Writers.Count()==0)
                {
                    context.Writers.AddRange(Writers);
                }

                context.SaveChanges();
            }
        }

        private static Category[] Categories = {
            new Category() { CategoryName="Telefon"},
            new Category() { CategoryName="Bilgisayar"},
            new Category() { CategoryName="Elektronik"}
        };

        private static Writer[] Writers = {
            new Writer() { Name="Mehmet"},
            new Writer() { Name="Ahmet"},
            new Writer() { Name="Ali"}
        };
        private static Article[] Articles =
        {
            new Article(){ ArticleHeader="Samsung S5", CoverLetter="test cover letter 1 ", Text="test text"},
            new Article(){ ArticleHeader="Samsung S5", CoverLetter="test cover letter 1 ", Text="test text"}
        };


    }
}
