using AutoMapper;
using EComPayApp.Application.DTOs.OrderDtos;
using EComPayApp.Application.Features.CQRS.Commands.Orders.CreateOrder;
using EComPayApp.Application.Features.CQRS.Commands.Products.CreateProduct;
using EComPayApp.Application.Features.CQRS.Queries.Order.GetOrder;
using EComPayApp.Application.Features.CQRS.Queries.Products.GetProduct;
using EComPayApp.Domain.Entities;


namespace EComPayApp.Application.Mappers.Profiles
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<Order, GetOrderResponse>().ReverseMap();
            CreateMap<Order, CreateOrderCommand>().ReverseMap();
        }
    }
}
