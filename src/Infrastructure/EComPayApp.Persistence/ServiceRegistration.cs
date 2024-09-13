using EComPayApp.Application.Interfaces.UoW;
using EComPayApp.Persistence.Contexts;
using EComPayApp.Persistence.UoW;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<EComPayAppDbContext>(options =>
            {
                options.UseSqlServer(Configuration.ConnectionString);
            });
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
