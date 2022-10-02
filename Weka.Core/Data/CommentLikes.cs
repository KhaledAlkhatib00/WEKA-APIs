using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Weka.Core.Data
{
    public class CommentLikes
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CommentId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        [ForeignKey("CommentId")]
        public virtual Commentt Commentt{ get; set; }
    }
}
