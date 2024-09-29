using EComPayApp.Application.Interfaces.Repositories.Orders;
using EComPayApp.Domain.Entities;
using EComPayApp.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Persistence.Repositories.Orders
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(EComPayAppDbContext context) : base(context)
        {
        }
    }
}
