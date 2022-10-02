using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Weka.Core.Data
{
    public class ContactUs
    {
        [Key]
        public int Id { get; set; }
        public string Subject { get; set; }
        public string MessageText { get; set; }
        
  
    }
}
