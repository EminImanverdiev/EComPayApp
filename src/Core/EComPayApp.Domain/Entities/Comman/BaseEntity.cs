

namespace EComPayApp.Domain.Entities.Comman
{
    public class BaseEntity<T>
    {
        public T Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
