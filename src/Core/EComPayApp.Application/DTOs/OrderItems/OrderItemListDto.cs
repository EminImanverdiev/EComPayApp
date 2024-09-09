using EComPayApp.Application.Interfaces.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Application.DTOs.OrderItems
{
    public class OrderItemListDto:IDto
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }   
        public int Quantity { get; set; }
        public float TotalPrice { get; set; }   
    }
}
