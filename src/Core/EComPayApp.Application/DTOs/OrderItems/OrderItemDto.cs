using EComPayApp.Application.DTOs.OrderDtos;
using EComPayApp.Application.DTOs.ProductDtos;
using EComPayApp.Application.Interfaces.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Application.DTOs.OrderItems
{
    public class GetOrderItemDto:IDto
    {
        public Guid ProductId { get; set; }
        public GetProductDto Product { get; set; } // Ürün bilgilerini içeren DTO
        public Guid OrderId { get; set; }
        public GetOrderDto Order { get; set; } // Sipariş bilgilerini içeren DTO
        public int Quantity { get; set; }
        public float TotalPrice { get; set; }
    }
}
