using EComPayApp.Application.Interfaces.Repositories.Customers;
using EComPayApp.Application.Interfaces.Repositories.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Application.Interfaces.UoW
{
    public interface IUnitOfWork:IDisposable
    {
        IProductRepository Products { get; }
        ICustomerRepository Customers { get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
