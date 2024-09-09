using EComPayApp.Application.Interfaces.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Application.DTOs.ProductDtos
{
    public class ProductListDto:IDto
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int Stock { get; set; }
        public float Price { get; set; }
        public Guid BranchId { get; set; }
    }
}
