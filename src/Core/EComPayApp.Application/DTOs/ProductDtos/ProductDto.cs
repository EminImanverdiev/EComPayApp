using EComPayApp.Application.DTOs.BranchDtos;
using EComPayApp.Application.DTOs.CategoryDtos;
using EComPayApp.Application.DTOs.OrderItems;
using EComPayApp.Application.Interfaces.DTO;

namespace EComPayApp.Application.DTOs.ProductDtos
{
    public class GetProductDto:IDto
    {
        public Guid Id { get; set; }
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public float Price { get; set; }
        public ICollection<GetOrderItemDto> OrderItems { get; set; } 
        public GetCategoryDto Category { get; set; } 
        public Guid BranchId { get; set; }
        public GetBranchDto Branch { get; set; }
    }
}
