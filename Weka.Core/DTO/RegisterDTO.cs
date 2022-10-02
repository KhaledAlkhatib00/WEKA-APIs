using System;
using System.Collections.Generic;
using System.Text;

namespace Weka.Core.DTO
{
    public class RegisterDTO
    {
       
       public int UserId { get; set; }  
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string UserImage { get; set; }

        
    }
}
