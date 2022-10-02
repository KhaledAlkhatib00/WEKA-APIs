using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Weka.Core.Data
{
    public class Testamoniall
    {
        [Key]
        public int Id { get; set; }
        public string MessageText { get; set; }
        public int Rate { get; set; }
        public int UserId { get; set; }
        

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
