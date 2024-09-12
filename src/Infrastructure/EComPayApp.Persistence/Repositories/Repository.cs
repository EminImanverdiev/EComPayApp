using EComPayApp.Application.Interfaces.Repositories;
using EComPayApp.Domain.Entities.Comman;
using EComPayApp.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Persistence.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity<Guid>
    {
        private readonly EComPayAppDbContext _context;
        public DbSet<T> Table => _context.Set<T>();

        public Repository(EComPayAppDbContext context)
        {
            _context = context;
        }

        // Read əməliyyatları
        public IQueryable<T> GetAll(bool tracking = true)
        {
            return tracking ? Table : Table.AsNoTracking();
        }

        public IQueryable<T> Get(Expression<Func<T, bool>> expression, bool tracking = true)
        {
            return tracking ? Table.Where(expression) : Table.Where(expression).AsNoTracking();
        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> expression, bool tracking = true)
        {
            return tracking ? await Table.FirstOrDefaultAsync(expression) : await Table.AsNoTracking().FirstOrDefaultAsync(expression);
        }

        public async Task<T> GetByIdAsync(string Id, bool tracking = true)
        {
            return tracking ? await Table.FindAsync(Id) : await Table.AsNoTracking().FirstOrDefaultAsync(e => e.Id.ToString() == Id);
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            return await Table.FindAsync(id);
        }

        // Write əməliyyatları
        public async Task<bool> AddAsync(T entity)
        {
            await Table.AddAsync(entity);
            return await SaveAsync(default) > 0;
        }

        public async Task<bool> AddRangeAsync(List<T> entities)
        {
            await Table.AddRangeAsync(entities);
            return await SaveAsync(default) > 0;
        }

        public bool Remove(T entity)
        {
            Table.Remove(entity);
            return SaveAsync(default).Result > 0;
        }

        public bool RemoveRange(List<T> entities)
        {
            Table.RemoveRange(entities);
            return SaveAsync(default).Result > 0;
        }

        public async Task<bool> RemoveAsync(string Id)
        {
            var entity = await GetByIdAsync(Id);
            if (entity == null) return false;
            Remove(entity);
            return true;
        }

        public bool Update(T entity)
        {
            Table.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            return SaveAsync(default).Result > 0;
        }
        public async Task<int> SaveAsync(CancellationToken cancellationToken = default)
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
