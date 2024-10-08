﻿using EComPayApp.Domain.Entities.Comman;

namespace EComPayApp.Domain.Entities
{
    public class Customer : BaseEntity<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public ICollection<Order> Orders { get; set; }
    }

}
