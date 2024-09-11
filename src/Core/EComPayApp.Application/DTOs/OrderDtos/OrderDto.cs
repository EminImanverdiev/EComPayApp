﻿using EComPayApp.Application.DTOs.CategoryDtos;
using EComPayApp.Application.DTOs.CustomerDtos;
using EComPayApp.Application.DTOs.OrderItems;
using EComPayApp.Application.DTOs.PaymentDtos;
using EComPayApp.Application.Interfaces.DTO;
using EComPayApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Application.DTOs.OrderDtos
{
    public class OrderDto:IDto<Guid>
    {
        public Guid Id { get; set; }

        public Guid CustomerId { get; set; }
        public CustomerDto Customer { get; set; } 
        public string Description { get; set; }
        public string Address { get; set; }
        public decimal? Discount { get; set; }
        public OrderStatus Status { get; set; }
        public ICollection<OrderItemDto> OrderItems { get; set; } = new List<OrderItemDto>(); 
        public ICollection<PaymentDto> Payments { get; set; } = new List<PaymentDto>(); 
        public float TotalPrice { get; set; } 
    }
}
