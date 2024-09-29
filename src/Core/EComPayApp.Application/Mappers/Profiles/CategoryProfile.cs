using AutoMapper;
using EComPayApp.Application.DTOs.CategoryDtos;
using EComPayApp.Application.Features.CQRS.Categories.Create;
using EComPayApp.Application.Features.CQRS.Categories.Update;
using EComPayApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Application.Mappers.Profiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CreateCategoryCommand>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryCommand>().ReverseMap();
        }
    }

}
