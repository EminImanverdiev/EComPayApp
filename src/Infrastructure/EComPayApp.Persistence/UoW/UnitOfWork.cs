using EComPayApp.Application.Interfaces.Repositories;
using EComPayApp.Application.Interfaces.Repositories.Branches;
using EComPayApp.Application.Interfaces.Repositories.Categories;
using EComPayApp.Application.Interfaces.Repositories.Contacts;
using EComPayApp.Application.Interfaces.Repositories.Customers;
using EComPayApp.Application.Interfaces.Repositories.Orders;
using EComPayApp.Application.Interfaces.Repositories.Products;
using EComPayApp.Application.Interfaces.UoW;
using EComPayApp.Persistence.Contexts;
using EComPayApp.Persistence.Repositories.Customers;
using EComPayApp.Persistence.Repositories.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Persistence.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EComPayAppDbContext _context;
        private IProductRepository _productRepository;
        private ICustomerRepository _customerRepository;

        public UnitOfWork(EComPayAppDbContext context)
        {
            _context = context;
        }

        public IProductRepository Products => _productRepository ??= new ProductRepository(_context);

        public ICustomerRepository Customers =>_customerRepository ??= new CustomerRepository(_context);

        public IBranchRepository Branches => throw new NotImplementedException();

        public ICategoryRepository Categories => throw new NotImplementedException();

        public IImageRepository Images => throw new NotImplementedException();

        public IContactRepository Contacts => throw new NotImplementedException();

        public IOrderRepository Orders => throw new NotImplementedException();

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
