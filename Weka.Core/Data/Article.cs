using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Weka.Core.Data
{
    public class Article
    {
        [Key]
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

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; } 

        [ForeignKey("CategoryId")]
        public virtual Activation Activation { get; set; }  

        [ForeignKey("CategoryId")]
        public virtual Blocked Blocked { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }


        public ICollection<Commentt> commentts { get; set; }
        public ICollection<Favorite>favorites { get; set; }
        public ICollection<LikeArticle>likeArticles { get; set; }
        public ICollection<Reports>reports { get; set; }
        public ICollection<Referencess>referencesses { get; set; }
        public ICollection<UserActivitys> userActivitys { get; set; }

    }
}
