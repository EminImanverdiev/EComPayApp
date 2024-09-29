using AutoMapper;
using EComPayApp.Application.DTOs.BranchDtos;
using EComPayApp.Application.Features.CQRS.Branches.Create;
using EComPayApp.Application.Features.CQRS.Branches.Update;
using EComPayApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Application.Mappers.Profiles
{
    public class BranchProfile : Profile
    {
        public BranchProfile()
        {
            CreateMap<Branch, CreateBranchCommand>().ReverseMap();
            CreateMap<Branch, BranchDto>().ReverseMap();
            CreateMap<Branch, UpdateBranchCommand>().ReverseMap();
        }
    }

}
