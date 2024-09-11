using EComPayApp.Domain.Entities.Comman;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Domain.Entities
{
    public class About:BaseEntity<Guid>
    {
        public string Title { get; set; } 
        public string Description { get; set; }  
        public string Vision { get; set; }  
        public string Mission { get; set; } 
    }
}
