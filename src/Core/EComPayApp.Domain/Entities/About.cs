using EComPayApp.Domain.Entities.Comman;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Domain.Entities
{
    public class About:BaseEntity
    {
        public Guid Id { get; set; }
        public string Title { get; set; }  // Başlıq (məsələn, "Haqqımızda")
        public string Description { get; set; }  // Şirkət haqqında mətn
        public string Vision { get; set; }  // Şirkətin baxışı
        public string Mission { get; set; }  // Şirkətin missiyası
    }
}
