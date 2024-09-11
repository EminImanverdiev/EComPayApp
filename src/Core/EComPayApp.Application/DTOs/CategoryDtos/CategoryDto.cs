using EComPayApp.Application.DTOs.ProductDtos;
using EComPayApp.Application.Interfaces.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Application.DTOs.CategoryDtos
{
    public class CategoryDto:IDto<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<ProductDto> Products { get; set; } = new List<ProductDto>();
    }
}
