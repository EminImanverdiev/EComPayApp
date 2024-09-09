using EComPayApp.Application.DTOs.ProductDtos;
using EComPayApp.Application.DTOs.AddressDtos;
using EComPayApp.Application.Interfaces.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Application.DTOs.BranchDtos
{
    public class GetBranchDto : IDto
    {
        public Guid AddressId { get; set; }
        public GetAddressDto Address { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public ICollection<GetProductDto> Products { get; set; } = new List<GetProductDto>();
    }
}
