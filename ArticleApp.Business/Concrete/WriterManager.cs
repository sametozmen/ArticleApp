using ArticleApp.Business.Abstract;
using ArticleApp.DataAccess.Abstract;
using ArticleApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleApp.Business.Concrete
{
    public class WriterManager : IWriterService
    {
        private IWriterDAL _writerDAL;
        public WriterManager(IWriterDAL writerDAL)
        {
            _writerDAL = writerDAL;
        }
        public void Add(Writer writer)
        {
            _writerDAL.Create(writer);
        }

        
        public void Delete(Writer writer)
        {
            _writerDAL.Delete(writer);
        }

        public List<Writer> GetAll()
        {
            return _writerDAL.GetAll();
        }
        
        public void Update(Writer writer)
        {
            _writerDAL.Update(writer);
        }
    }
}
