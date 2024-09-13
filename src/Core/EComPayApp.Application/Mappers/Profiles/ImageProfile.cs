using AutoMapper;
using EComPayApp.Application.DTOs.ImageDtos;
using EComPayApp.Application.Features.CQRS.Commands.Images.CreateImage;
using EComPayApp.Application.Features.CQRS.Commands.Payments.CreatePayment;
using EComPayApp.Application.Features.CQRS.Queries;
using EComPayApp.Domain.Entities;


namespace EComPayApp.Application.Mappers.Profiles
{
    public class ImageProfile : Profile
    {
        public ImageProfile()
        {
            CreateMap<Image, GetImageResponse>().ReverseMap();
            CreateMap<Image, CreateImageCommand>().ReverseMap();
        }
    }
}
