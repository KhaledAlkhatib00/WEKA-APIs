using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Weka.Core.Data
{
    public class Referencess
    {
        [Key]
        public int Id { get; set; }
        public string ReffName { get; set; }
        public string ReffLink { get; set; }
        public int ArticleId { get; set; }

        [ForeignKey("ArticleId")]
        public virtual Article Article { get; set; }
    }
}
