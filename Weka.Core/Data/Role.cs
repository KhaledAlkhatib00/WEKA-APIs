using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Weka.Core.Data
{
    public class Role
    {
        [Key]
        public int Id {get;set;}
        public string RoleName {get;set;}

        public ICollection<User> users { get; set; }

    }
}
