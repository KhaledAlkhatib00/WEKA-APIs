using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Weka.Core.Data
{
    public class BadWord
    {
        [Key]
        public int Id { get; set; }
        public string Word { get; set; }

    }
}
