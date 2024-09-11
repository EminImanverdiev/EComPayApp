using EComPayApp.Domain.Entities.Comman;

namespace EComPayApp.Domain.Entities
{
    
    public class Product : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public float Price { get; set; }
        public Guid CategoryId { get; set; }
        public Guid BranchId { get; set; }
        public Category Category { get; set; }
        public Branch Branch { get; set; }
        public ICollection<Image> Images { get; set; } = new List<Image>();
        public ICollection<OrderItem> OrderItems { get; set; }

    }

}
