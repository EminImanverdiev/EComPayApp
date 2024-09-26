using EComPayApp.Application.Interfaces.Repositories.Customers;
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
