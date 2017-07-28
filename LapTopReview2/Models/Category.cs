using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LapTopReview2.Models
{
    public class Category
    {
        [Key]

        public int CategoryID { get; set; }
        public string Brand { get; set; }

        public ICollection<Review> Reviews { get; set; }
    }
}