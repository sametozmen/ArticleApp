using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleApp.Entities
{
    public class Article:BaseEntity
    {
        public string ArticleHeader { get; set; }
        public string CoverLetter { get; set; }
        public string Text { get; set; }
        public int CategoryID { get; set; }
        public int WriterID { get; set; }
        public int ViewCounter { get; set; } = 0;
    }
}
