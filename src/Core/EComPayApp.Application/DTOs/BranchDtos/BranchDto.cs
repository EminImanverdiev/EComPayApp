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
    public class BranchDto : IDto<Guid>
    {
        public Guid Id { get; set; }
        public Guid AddressId { get; set; }
        public AddressDto Address { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public ICollection<ProductDto> Products { get; set; } = new List<ProductDto>();
    }
}
