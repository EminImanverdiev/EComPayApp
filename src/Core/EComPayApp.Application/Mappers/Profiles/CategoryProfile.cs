using AutoMapper;
using EComPayApp.Application.DTOs.CategoryDtos;
using EComPayApp.Application.Features.CQRS.Commands.Categories.CreateCategory;
using EComPayApp.Application.Features.CQRS.Commands.Payments.CreatePayment;
using EComPayApp.Application.Features.CQRS.Queries;
using EComPayApp.Domain.Entities;


namespace EComPayApp.Application.Mappers.Profiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, GetCategoryResponse>().ReverseMap();
            CreateMap<Category, CreateCategoryCommand>().ReverseMap();
        }
    }
}
