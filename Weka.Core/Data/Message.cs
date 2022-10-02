using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Weka.Core.Data
{
    public class Message
    {
        [Key]
        public int Id { get; set; }
        public string MessageText { get; set; }
        public string Email { get; set; }

    }
}
