using System;
using System.Collections.Generic;
using System.Text;

namespace Weka.Core.DTO
{
    public class PostInformationDTO
    {

        public string FName { get; set; }
        public string LName { get; set; }
        public string CategoryName { get; set; }
        public int Id { get; set; }
        public string ArticleTitel { get; set; }
        public string ArticleGrapgh { get; set; }
        public DateTime PublishDate { get; set; }
        public int CategoryId { get; set; }
        public int ActiveStatus { get; set; }
        public int BlockStatus { get; set; }
        public int views { get; set; }
        public string ArticleImage { get; set; }
        public int UserId { get; set; }
    }
}
