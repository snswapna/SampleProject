
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Microsoft.Practices.Unity;
using SampleProject.Repository;
using SampleProject.Controllers.API;
using SampleProject.DTOs;
using System.Collections.Generic;
using SampleProject.Models;
using System.Web.Http;
using System.Threading;


namespace SampleProject.Tests.Controllers
{
    [TestClass]
    public class StateControllerTest
    {
        IUnityContainer testContainer;
        Mock<IStateRepository> testStateRepository;
        StatesController testStatesController;

        [TestInitialize]
        public void InitializeTest()
        {
            testContainer = new UnityContainer();
            testStateRepository = new Mock<IStateRepository>();

            testContainer.RegisterInstance(testStateRepository);

            testStatesController = new StatesController(testStateRepository.Object);
        }


        [TestMethod()]
        public void GeStatesTest()
        {
            //Arrange
            var products = new List<States>()
            {
             new States() { Id = 1, Name = "Arizona", ShortName="AZ", Tax=5 },
             new States() { Id = 2, Name = "Florida", ShortName="FL", Tax=0 },
            };

            testStateRepository.Setup(x => x.GetAll()).Returns(products);

            //Act
            IHttpActionResult actionResult = testStatesController.GetStates();


            //Assert
            testStateRepository.Verify();
            Assert.IsNotNull(actionResult);


        }


    }
}


