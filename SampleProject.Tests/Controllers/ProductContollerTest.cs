using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Microsoft.Practices.Unity;
using SampleProject.Repository;
using SampleProject.Controllers.API;
using SampleProject.DTOs;
using System.Collections.Generic;
using SampleProject.Models;
using System.Web.Http;
using System.Web.Http.Results;

namespace SampleProject.Tests.Controllers
{
    [TestClass]
    public class ProductControllerTest
    {
        IUnityContainer testContainer;
        Mock<IProductRepository> testProductRepository;
        ProductsController testProductsController;

        [TestInitialize]
        public void InitializeTest()
        {
            testContainer = new UnityContainer();
            testProductRepository = new Mock<IProductRepository>();
            testContainer.RegisterInstance(testProductRepository);
            testProductsController = new ProductsController(testProductRepository.Object);
        }


        [TestMethod()]
        public void GetProductsTest()
        {
            //Arrange
            var products = new List<Products>()
            {
             new Products() { Id = 1, Name = "Jumper Roo", Price = 110, Discount = 5 },
             new Products() { Id = 2, Name = "Baby Walker", Price = 49, Discount = 0 }
            };

            testProductRepository.Setup(x => x.GetAll()).Returns(products);

            //Act
            IHttpActionResult actionResult = testProductsController.GetProducts();

          
            //Assert
            testProductRepository.Verify();
            Assert.IsNotNull(actionResult);

        }


        public void GetProductTest()
        {
            //Arrange


            
            //Act



            //Assert


        }

    }
}
