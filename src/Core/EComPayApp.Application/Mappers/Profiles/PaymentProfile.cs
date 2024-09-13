using AutoMapper;
using EComPayApp.Application.DTOs.PaymentDtos;
using EComPayApp.Application.Features.CQRS.Commands.Payments.CreatePayment;
using EComPayApp.Application.Features.CQRS.Commands.Products.CreateProduct;
using EComPayApp.Application.Features.CQRS.Queries;
using EComPayApp.Application.Features.CQRS.Queries.Products.GetProduct;
using EComPayApp.Domain.Entities;


namespace EComPayApp.Application.Mappers.Profiles
{
    public class PaymentProfile : Profile
    {
        public PaymentProfile()
        {
            CreateMap<Payment, GetPaymentResponse>().ReverseMap();
            CreateMap<Payment, CreatePaymentCommand>().ReverseMap();
        }
    }

}
