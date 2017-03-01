using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using SampleProject.Models;
using SampleProject.DTOs;

namespace SampleProject.App_Start
{
    public class MappingProfile:Profile
    {

        public MappingProfile()
        {
            Mapper.CreateMap<Products, ProductDto>();
            Mapper.CreateMap<ProductDto, Products>();

            Mapper.CreateMap<States, StateDto>();
            Mapper.CreateMap<StateDto, States>();
        }
    }
}