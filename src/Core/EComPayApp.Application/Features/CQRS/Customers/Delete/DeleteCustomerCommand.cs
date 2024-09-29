using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Application.Features.CQRS.Customers.Delete
{
    public class DeleteCustomerCommand : IRequest<DeleteCustomerResponse>
    {
        public Guid Id { get; set; }
    }
}
