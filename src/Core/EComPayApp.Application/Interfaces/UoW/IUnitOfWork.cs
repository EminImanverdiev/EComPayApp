using EComPayApp.Application.Interfaces.Repositories;
using EComPayApp.Application.Interfaces.Repositories.Branches;
using EComPayApp.Application.Interfaces.Repositories.Categories;
using EComPayApp.Application.Interfaces.Repositories.Contacts;
using EComPayApp.Application.Interfaces.Repositories.Customers;
using EComPayApp.Application.Interfaces.Repositories.Orders;
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
        IBranchRepository Branches { get; }
        ICategoryRepository Categories { get; }
        IImageRepository Images { get; }
        IContactRepository Contacts { get ;}
        IOrderRepository Orders { get; }


        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
