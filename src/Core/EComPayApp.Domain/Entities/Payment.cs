using EComPayApp.Domain.Entities.Comman;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Domain.Entities
{
    public class Payment:BaseEntity
    {
        public Guid OrderId { get; set; }
        public float Amount { get; set; }
        public string PaymentMethod { get; set; }
        public bool Status { get; set; }
        public Order Order { get; set; }
    }

}
