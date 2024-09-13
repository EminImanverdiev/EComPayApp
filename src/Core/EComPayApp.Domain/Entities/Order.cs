using EComPayApp.Domain.Entities.Comman;
using EComPayApp.Domain.Enums;

namespace EComPayApp.Domain.Entities
{
    public class Order : BaseEntity<Guid>
    {
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public decimal? Discount { get; set; }
        public OrderStatus Status { get; set; }
        public ICollection<Payment> Payments { get; set; }
    }

}
