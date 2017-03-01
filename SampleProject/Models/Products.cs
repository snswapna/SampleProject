using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SampleProject.Models
{
    public class Products
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public int Price { get; set; }

        public int Discount { get; set;}


        
    }
}