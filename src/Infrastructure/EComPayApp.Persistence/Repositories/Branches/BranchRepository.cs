using EComPayApp.Application.Interfaces.Repositories;
using EComPayApp.Application.Interfaces.Repositories.Branches;
using EComPayApp.Domain.Entities;
using EComPayApp.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Persistence.Repositories.Branches
{
    public class BranchRepository : Repository<Branch>, IBranchRepository
    {
        public BranchRepository(EComPayAppDbContext context) : base(context)
        {
        }
    }

}
