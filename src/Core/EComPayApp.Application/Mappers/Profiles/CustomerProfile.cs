using AutoMapper;
using EComPayApp.Application.DTOs.CustomerDtos;
using EComPayApp.Application.Features.CQRS.Customers.Create;
using EComPayApp.Application.Features.CQRS.Customers.Update;
using EComPayApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Application.Mappers.Profiles
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<Customer, CreateCustomerCommand>().ReverseMap();
            CreateMap<Customer, CustomerDto>().ReverseMap();
            CreateMap<Customer, UpdateCustomerCommand>().ReverseMap();
        }
    }

}
