using EComPayApp.Domain.Entities.Comman;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Domain.Entities
{
    public class Category : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }

}
