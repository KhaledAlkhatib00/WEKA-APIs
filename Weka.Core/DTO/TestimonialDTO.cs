using System;
using System.Collections.Generic;
using System.Text;

namespace Weka.Core.DTO
{
    public class TestimonialDTO
    {
        public int Id { get; set; }
        public string MessageText { get; set; }
        public int Rate { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public int ShowStatus { get; set;}
    }
}
