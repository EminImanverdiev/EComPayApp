using AutoMapper;
using EComPayApp.Application.DTOs.CustomerDtos;
using EComPayApp.Application.Features.CQRS.Commands.Customers.CreateCustomer;
using EComPayApp.Application.Features.CQRS.Commands.Payments.CreatePayment;
using EComPayApp.Application.Features.CQRS.Queries;
using EComPayApp.Application.Features.CQRS.Queries.Customer.GetCustomer;
using EComPayApp.Domain.Entities;

namespace EComPayApp.Application.Mappers.Profiles
{
    public class CustomerMappingProfile : Profile
    {
        public CustomerMappingProfile()
        {
            CreateMap<CreateCustomerCommand, Customer>()
                .ForMember(dest => dest.Id, opt => opt.Ignore()); 

            CreateMap<Customer, GetCustomerDto>().ReverseMap();
            CreateMap<Customer, GetCustomerResponse>().ReverseMap();
            CreateMap<Customer, CreateCustomerCommand>().ReverseMap();
        }
    }
}
