using AutoMapper;
using EComPayApp.Application.DTOs.OrderDtos;
using EComPayApp.Application.DTOs.OrderItems;
using EComPayApp.Application.Features.CQRS.Commands.OrderItems.CreateOrderItem;
using EComPayApp.Application.Features.CQRS.Commands.Products.CreateProduct;
using EComPayApp.Application.Features.CQRS.Queries.Products.GetProduct;
using EComPayApp.Domain.Entities;


namespace EComPayApp.Application.Mappers.Profiles
{
    public class OrderItemProfile : Profile
    {
        public OrderItemProfile()
        {
            CreateMap<OrderItem, CreateOrderItemResponse>().ReverseMap();
            CreateMap<OrderItem, CreateOrderItemCommand>().ReverseMap();
        }
    }
}
