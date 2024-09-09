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
        public string Address { get; set; }  // Ünvan
        public string PhoneNumber { get; set; }  // Telefon nömrəsi
        public string Email { get; set; }  // Email ünvanı
        public string WorkingHours { get; set; }  // İş saatları
        public string MapLocation { get; set; }  // Xəritədə yer
    }
}
