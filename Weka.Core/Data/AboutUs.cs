using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Weka.Core.Data
{
    public class AboutUs
    {
        [Key]
        public int Id { get; set; }
        public string AboutText { get; set; }
        public string LocationPath { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }

       

    }
}
