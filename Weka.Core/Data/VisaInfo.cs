using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Weka.Core.Data
{
    public class VisaInfo
    {
        [Key]
        public int Id { get; set; }
        public int VisaNumber { get; set; }
        public int CV { get; set; }
        public int Blance { get; set; }
        public int mm { get; set; }
        public int yy { get; set; }

        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
