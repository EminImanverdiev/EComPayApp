using EComPayApp.Domain.Entities.Comman;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Application.Interfaces.Repositories
{
    public interface IRepository<T> where T : BaseEntity<Guid>
    {
        DbSet<T> Table { get; }

        // Read əməliyyatları
        IQueryable<T> GetAll(bool tracking = true);
        IQueryable<T> Get(Expression<Func<T, bool>> expression, bool tracking = true);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> expression, bool tracking = true);
        Task<T> GetByIdAsync(string Id, bool tracking = true);
        Task<T> GetByIdAsync(Guid id);

        // Write əməliyyatları
        Task<bool> AddAsync(T entity);
        Task<bool> AddRangeAsync(List<T> entities);
        bool Remove(T entity);
        bool RemoveRange(List<T> entities);
        Task<bool> RemoveAsync(string Id);
        bool Update(T entity);
        Task<int> SaveAsync(CancellationToken cancellationToken);
    }
}
