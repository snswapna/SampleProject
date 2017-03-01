using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SampleProject.Models;

namespace SampleProject.Repository
{
    public interface IStateRepository
    {
        IEnumerable<States> GetAll();
        States Get(int id);
    }
}