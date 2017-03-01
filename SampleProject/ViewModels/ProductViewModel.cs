using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SampleProject.Models;

namespace SampleProject.ViewModels
{
    public class ProductViewModel
    {
        public IEnumerable<Products> Products { get; set; }
        public IEnumerable<States> States { get; set; }

    }
}