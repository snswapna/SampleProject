using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SampleProject.Repository;
using SampleProject.Models;

namespace SampleProject.Repository
{
    public class ProductRepository: IProductRepository
    {
        private ApplicationDbContext _dbContext;

        public ProductRepository()
        {
            _dbContext = new ApplicationDbContext();
        }

        public IEnumerable<Products> GetAll()
        {
            var productsQuery = _dbContext.Products;
            return productsQuery;
        }

        public Products Get(int id)
        {
            var product = _dbContext.Products.SingleOrDefault(c => c.Id == id);
            return product;
        }
    }
}