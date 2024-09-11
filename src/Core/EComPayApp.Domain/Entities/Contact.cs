using EComPayApp.Domain.Entities.Comman;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Domain.Entities
{
    public class Contact:BaseEntity
    {
        public Guid Id { get; set; }
        public string Address { get; set; }  
        public string PhoneNumber { get; set; } 
        public string Email { get; set; } 
        public string WorkingHours { get; set; }  
        public string MapLocation { get; set; }
    }
}
