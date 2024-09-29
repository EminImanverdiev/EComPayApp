using AutoMapper;
using EComPayApp.Application.DTOs.OrderDtos;
using EComPayApp.Application.Features.CQRS.Orders.Create;
using EComPayApp.Application.Features.CQRS.Orders.Update;
using EComPayApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Application.Mappers.Profiles
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<Order, CreateOrderCommand>().ReverseMap();
            CreateMap<Order, OrderDto>().ReverseMap();
            CreateMap<Order, UpdateOrderCommand>().ReverseMap();
        }
    }

}
