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
    public class StatesController: ApiController
    {
        //private ApplicationDbContext _dbContext;

        readonly IStateRepository _repository;
        public StatesController() : base()
        {
        }
        public StatesController(IStateRepository repository)
        {
            this._repository = repository;
        }
        public IHttpActionResult GetStates()
        {

           // return _dbContext.States.ToList().Select(Mapper.Map<States, StateDto>);

            var statesQuery = _repository.GetAll();

            var statesDtos = statesQuery.ToList().Select(Mapper.Map<States, StateDto>);

            return Ok(statesDtos);

        }

        public IHttpActionResult Ge(int id)
        {
            var state = _repository.Get(id);
            
            if (state == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return Ok(Mapper.Map<States, StateDto>(state));
        }


    }
}