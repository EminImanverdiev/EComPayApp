using EComPayApp.Application.Interfaces.Repositories.Categories;
using EComPayApp.Domain.Entities;
using EComPayApp.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Persistence.Repositories.Categories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(EComPayAppDbContext context) : base(context)
        {
        }
    }
}
