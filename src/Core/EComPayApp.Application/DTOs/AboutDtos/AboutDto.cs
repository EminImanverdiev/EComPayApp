using EComPayApp.Application.Interfaces.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Application.DTOs.AboutDtos
{
    public class AboutDto:IDto<Guid>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }  
        public string Description { get; set; } 
        public string Vision { get; set; }  
        public string Mission { get; set; }  
    }
}
