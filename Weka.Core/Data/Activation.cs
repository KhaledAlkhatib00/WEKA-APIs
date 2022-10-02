using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Weka.Core.Data
{
    public class Activation
    {
        [Key]
        public int Id { get; set; }
        public string Status { get; set; }

        public ICollection<Article> articles { get; set; }

    }
}
