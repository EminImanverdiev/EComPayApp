using AutoMapper;
using EComPayApp.Application.DTOs.AddressDtos;
using EComPayApp.Application.Features.CQRS.Commands.Address.CreateAddress;
using EComPayApp.Application.Features.CQRS.Commands.Payments.CreatePayment;
using EComPayApp.Application.Features.CQRS.Queries;
using EComPayApp.Application.Features.CQRS.Queries.Address.GetAddress;
using EComPayApp.Domain.Entities;


namespace EComPayApp.Application.Mappers.Profiles
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            CreateMap<Address, GetAddressResponse>().ReverseMap();
            CreateMap<Address, CreateAddressCommand>().ReverseMap();
        }
    }
}
