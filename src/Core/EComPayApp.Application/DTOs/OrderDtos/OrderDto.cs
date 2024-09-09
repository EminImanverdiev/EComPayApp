using EComPayApp.Application.DTOs.CategoryDtos;
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
    public class GetOrderDto:IDto
    {
        public Guid CustomerId { get; set; }
        public GetCustomerDto Customer { get; set; } 
        public string Description { get; set; }
        public string Address { get; set; }
        public decimal? Discount { get; set; }
        public OrderStatus Status { get; set; }
        public ICollection<GetOrderItemDto> OrderItems { get; set; } = new List<GetOrderItemDto>(); 
        public ICollection<GetPaymentDto> Payments { get; set; } = new List<GetPaymentDto>(); 
        public float TotalPrice { get; set; } 
    }
}
