using AutoMapper;
using EComPayApp.Application.DTOs.ContactDtos;
using EComPayApp.Application.Features.CQRS.Contacts.Create;
using EComPayApp.Application.Features.CQRS.Contacts.Update;
using EComPayApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Application.Mappers.Profiles
{
    public class ContactProfile : Profile
    {
        public ContactProfile()
        {
            CreateMap<Contact, CreateContactCommand>().ReverseMap();
            CreateMap<Contact, ContactDto>().ReverseMap();
            CreateMap<Contact, UpdateContactCommand>().ReverseMap();
        }
    }

}
