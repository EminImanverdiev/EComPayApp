using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Application.Features.CQRS.Commands.Products.DeleteProduct
{
    public class DeleteProductCommand : IRequest<DeleteProductResponse>
    {
        public Guid Id { get; set; }
    }
}