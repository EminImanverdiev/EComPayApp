using AutoMapper;
using EComPayApp.Application.DTOs.BranchDtos;
using EComPayApp.Application.Features.CQRS.Commands.Branches.CreateBranch;
using EComPayApp.Application.Features.CQRS.Commands.Customers.CreateCustomer;
using EComPayApp.Domain.Entities;


namespace EComPayApp.Application.Mappers.Profiles
{
    public class BranchProfile : Profile
    {
        public BranchProfile()
        {
           
            CreateMap<CreateBranchCommand, Branch>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());
            CreateMap<Branch, GetBranchDto>().ReverseMap();
        }
    }
}
