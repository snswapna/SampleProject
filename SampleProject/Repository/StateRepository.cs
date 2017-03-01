using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SampleProject.Repository;
using SampleProject.Models;


namespace SampleProject.Repository
{
    public class StateRepository:IStateRepository
    {
        private ApplicationDbContext _dbContext;

        public StateRepository()
        {
            _dbContext = new ApplicationDbContext();
        }

        public IEnumerable<States> GetAll()
        {
            var statesQuery = _dbContext.States;
            return statesQuery;
        }

        public States Get(int id)
        {
            var states = _dbContext.States.SingleOrDefault(c => c.Id == id);
            return states;
        }
    }
}