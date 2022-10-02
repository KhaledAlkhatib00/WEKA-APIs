using System;
using System.Collections.Generic;
using System.Text;

namespace Weka.Core.DTO
{
    public class ReportDTO
    {
        public string ArticleTitel { get; set; }
        public DateTime PublishDate { get; set; }
        public int ActiveStatus { get; set; }
        public int BlockStatus { get; set; }
        public int views { get; set; }
        public string ArticleImage { get; set; }

        public string Fname { get; set; }
        public string Lname { get; set; }
    }
}
    
