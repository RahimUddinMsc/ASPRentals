using AspRentals.Dtos;
using AspRentals.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspRentals.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<CustomerDto, Customer>().ForMember(c => c.Id, opt => opt.Ignore());
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();

            Mapper.CreateMap<MovieDto, Movie>().ForMember(m => m.id, opt => opt.Ignore());
            Mapper.CreateMap<Movie, MovieDto>();
            Mapper.CreateMap<Genre, GenreDto>();
           
        }
    }
}