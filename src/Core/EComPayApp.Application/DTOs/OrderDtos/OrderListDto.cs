using EComPayApp.Application.Interfaces.DTO;
using EComPayApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Application.DTOs.OrderDtos
{
    public class OrderListDto:IDto
    {
        public Guid OrderId { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public OrderStatus Status { get; set; }
        public float TotalPrice { get; set; }
    }
}
