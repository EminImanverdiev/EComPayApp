using AutoMapper;
using EComPayApp.Application.DTOs.ImageDtos;
using EComPayApp.Application.Features.CQRS.Images.Create;
using EComPayApp.Application.Features.CQRS.Images.Update;
using EComPayApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Application.Mappers.Profiles
{
    public class ImageProfile : Profile
    {
        public ImageProfile()
        {
            CreateMap<Image, CreateImageCommand>().ReverseMap();
            CreateMap<Image,GetImageDto>().ReverseMap();
            CreateMap<Image, UpdateImageCommand>().ReverseMap();
        }
    }

}
