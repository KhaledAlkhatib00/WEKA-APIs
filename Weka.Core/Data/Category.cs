using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Weka.Core.Data
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string CategoryImage { get; set; }

        public ICollection<Article> articles { get; set; }

    }
}
