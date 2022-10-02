using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Weka.Core.Data
{
    public class Blocked
    {
        [Key]
        public int BlockId { get; set; }
        public string RoleName { get; set; }

        public ICollection<User> users { get; set; }
        public ICollection<Article> articles { get; set; }
    }
}
