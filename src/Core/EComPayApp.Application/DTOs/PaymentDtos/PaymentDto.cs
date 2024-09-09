using EComPayApp.Application.DTOs.OrderDtos;
using EComPayApp.Application.Interfaces.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Application.DTOs.PaymentDtos
{
    public class GetPaymentDto:IDto
    {
        public Guid OrderId { get; set; }
        public float Amount { get; set; }
        public string PaymentMethod { get; set; }
        public bool Status { get; set; }
        public GetOrderDto Order { get; set; }
    }
}
