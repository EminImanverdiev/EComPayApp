using EComPayApp.Domain.Entities.Comman;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Domain.Entities
{
    
    public class OrderItem : BaseEntity
    {
        public Guid ProductId { get; set; }
        public Product Product { get; set; } 
        public Guid OrderId { get; set; }
        public Order Order { get; set; }
        public int Quantity { get; set; }

        public float TotalPrice
        {
            get
            {
                return Product.Price * Quantity;
            }
        }
    }

}
