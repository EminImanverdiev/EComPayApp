using EComPayApp.Application.DTOs.OrderDtos;
using EComPayApp.Application.Interfaces.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Application.DTOs.CustomerDtos
{
    public class GetCustomerDto:IDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public ICollection<GetOrderDto> Orders { get; set; } = new List<GetOrderDto>();
    }
}
