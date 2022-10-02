using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Weka.Core.Data
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email{ get; set; }
        public string PhoneNumber { get; set; }
        public int BlockStatus  { get; set; }
        public string UserImage  { get; set; }

        

        [ForeignKey("BlockStatus")]
        public virtual Blocked Blocked { get; set; }

        public ICollection<Commentt>commentts { get; set; }
        public ICollection<Favorite> favorites { get; set; }
        public ICollection<CommentLikes>commentLikes { get; set; }
        public ICollection<LikeArticle> likeArticles { get; set; }
        public ICollection<Reports> reports { get; set; }
        public ICollection<VisaInfo> visaInfos { get; set; }
        public ICollection<Testamoniall> testamonialls { get; set; }
        public ICollection<Article> articles { get; set; }
        public ICollection<UserActivitys> userActivitys { get; set; }



    }
}
