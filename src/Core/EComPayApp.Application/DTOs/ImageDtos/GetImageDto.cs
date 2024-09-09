using EComPayApp.Application.Interfaces.DTO;
using EComPayApp.Domain.Entities;

namespace EComPayApp.Application.DTOs.ImageDtos
{
    public class GetImageDto:IDto<Guid>
    {
        public Guid ProductId { get; set; }
        public string ImageUrl { get; set; }
        public bool IsMainImage { get; set; }
        public Product Product { get; set; }
    }
}
