using EComPayApp.Application.Interfaces.Repositories.Contacts;
using EComPayApp.Domain.Entities;
using EComPayApp.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Persistence.Repositories.Contacts
{
    public class ContactRepository : Repository<Contact>, IContactRepository
    {
        public ContactRepository(EComPayAppDbContext context) : base(context)
        {
        }
    }
}
