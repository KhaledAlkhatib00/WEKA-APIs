using System;
using System.Collections.Generic;
using System.Text;

namespace Weka.Core.DTO
{
    public class ArticleCategoryDTO
    {
        public int Id { get; set; }
        public string ArticleTitel { get; set; }
        public string ArticleGrapgh { get; set; }
        public DateTime PublishDate { get; set; }
        public int views { get; set; }
        public string ArticleImage { get; set; }
    }
}
