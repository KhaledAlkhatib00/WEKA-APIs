using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Weka.Core.Data
{
    public class Commentt
    {
        [Key]
        public int Id { get; set; }
        public string CommentText { get; set; }
        public DateTime CommentDate { get; set; }
        public int ArticleId { get; set; }
        public int UserId { get; set; }

        [ForeignKey("ArticleId")]
        public virtual Article Article { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        public ICollection<CommentLikes> commentLikes { get; set; }

    }
}
