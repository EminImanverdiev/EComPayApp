using EComPayApp.Application.DTOs.ProductDtos;
using EComPayApp.Application.Interfaces.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Application.DTOs.CategoryDtos
{
    public class GetCategoryDto:IDto
    {
        public string Name { get; set; }
        public ICollection<GetProductDto> Products { get; set; } = new List<GetProductDto>();
    }
}
