using System;
using System.Collections.Generic;
using System.Text;

namespace Weka.Core.DTO
{
    public class LoginDTO
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }    
        public string RoleName { get; set; }
        public string blockStatus { get; set; }
    }
}
