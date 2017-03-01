using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SampleProject.Models;

namespace SampleProject.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Products> GetAll();
        Products Get(int id);
    }
}