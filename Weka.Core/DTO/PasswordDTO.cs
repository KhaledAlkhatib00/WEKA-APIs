using System;
using System.Collections.Generic;
using System.Text;

namespace Weka.Core.DTO
{
    public class PasswordDTO
    {
        public int UserId { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
    }
}