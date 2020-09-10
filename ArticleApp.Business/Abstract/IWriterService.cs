using ArticleApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleApp.Business.Abstract
{
    public interface IWriterService
    {
        List<Writer> GetAll();
        Writer GetById(int wrID);
        void Add(Writer writer);
        void Delete(int wrID);
        void Update(Writer writer);
    }
}
