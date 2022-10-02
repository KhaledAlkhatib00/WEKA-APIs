using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Weka.Core.Data
{
    public class UserActivitys
    {
        [Key]
        public int Id { get; set; }
        public string ActivityText { get; set; }
        public int atctivityId { get; set; }
        public int UserId { get; set; }
        public int ArticleId { get; set; }


        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        [ForeignKey("ArticleId")]
        public virtual Article Article { get; set; }
    }
}
