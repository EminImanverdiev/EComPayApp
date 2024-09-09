using EComPayApp.Application.Interfaces.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Application.DTOs.ContactDtos
{
    public class ContactListDto:IDto
    {
        public Guid Id { get; set; }
        public string Address { get; set; }  
        public string PhoneNumber { get; set; }  
    }
}
