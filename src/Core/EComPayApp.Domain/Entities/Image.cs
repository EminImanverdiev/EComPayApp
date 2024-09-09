using EComPayApp.Domain.Entities.Comman;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Domain.Entities
{
    public class Image:BaseEntity
    {
        public Guid ProductId { get; set; }
        public string ImageUrl { get; set; }
        public bool IsMainImage { get; set; }
        public Product Product { get; set; }
    }
}
