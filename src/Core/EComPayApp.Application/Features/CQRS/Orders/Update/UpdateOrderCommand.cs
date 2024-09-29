using EComPayApp.Application.DTOs.OrderDtos;
using EComPayApp.Application.DTOs.PaymentDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Application.Features.CQRS.Orders.Update
{
    public class UpdateOrderCommand : IRequest<UpdateOrderResponse>
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public decimal Discount { get; set; }
        public ICollection<OrderDto> OrderItems { get; set; }
        public ICollection<PaymentDto> Payments { get; set; }
    }

}
