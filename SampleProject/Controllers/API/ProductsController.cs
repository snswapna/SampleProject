using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI;
using SampleProject.Models;
using SampleProject.DTOs;
using AutoMapper;
using SampleProject.Repository;
using Microsoft.Practices.Unity;
using Unity.Mvc4;


namespace SampleProject.Controllers.API
{
    public class ProductsController : ApiController
    {
        //private ApplicationDbContext _dbContext;
        readonly IProductRepository _repository;
        public ProductsController(IProductRepository repository)
        {
            this._repository = repository;
        }
        public IHttpActionResult GetProducts()
        {
            //var productsQuery = _dbContext.Products;
            var productsQuery = _repository.GetAll();
            var productDtos = productsQuery.ToList().Select(Mapper.Map<Products, ProductDto>);

            return Ok(productDtos);

        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = _repository.Get(id);

            if (product == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return Ok(Mapper.Map<Products, ProductDto>(product));
        }

        //[HttpPost]
        //public IHttpActionResult CreateProduct(ProductDto productdto)
        //{
        //    if (!ModelState.IsValid)
        //        return BadRequest();
        //    var product = Mapper.Map<ProductDto, Products>(productdto);
        //    _dbContext.Products.Add(product);
        //    _dbContext.SaveChanges();

        //    productdto.Id = product.Id;

        //    return Created(new Uri(Request.RequestUri + "/" + product.Id), productdto);
        //}

        //[HttpPut]
        //public void UpdateProduct(int id, ProductDto productdto)
        //{
        //    if (!ModelState.IsValid)
        //        throw new HttpResponseException(HttpStatusCode.NotFound);
        //    var productFromdb = _dbContext.Products.SingleOrDefault(c => c.Id == id);

        //        if (productFromdb == null)
        //        throw new HttpResponseException(HttpStatusCode.NotFound);
        //    Mapper.Map(productdto, productFromdb);

        //    _dbContext.SaveChanges();


        //}
        //[HttpDelete]
        //public void DeleteProduct(int id, Products product)
        //{
        //    if (!ModelState.IsValid)
        //        throw new HttpResponseException(HttpStatusCode.NotFound);
        //    var productFromdb = _dbContext.Products.SingleOrDefault(c => c.Id == id);

        //    if (productFromdb == null)
        //        throw new HttpResponseException(HttpStatusCode.NotFound);



        //    _dbContext.Products.Remove(productFromdb);
        //    _dbContext.SaveChanges();


        //}
    }
}
