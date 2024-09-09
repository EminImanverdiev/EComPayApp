using EComPayApp.Application.DTOs.BranchDtos;
using EComPayApp.Application.Interfaces.DTO;
namespace EComPayApp.Application.DTOs.AddressDtos
{
    public class AddreessListDto:IDto
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public ICollection<BranchListDto> Branches { get; set; }
    }
}
