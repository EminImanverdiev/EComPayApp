using EComPayApp.Application.Features.CQRS.Products.Create;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServises(this IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddFluentValidation(fv =>
            fv.RegisterValidatorsFromAssemblyContaining<CreateProductCommandValidator>());
        }
    }
}
