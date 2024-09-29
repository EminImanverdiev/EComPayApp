using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Application.Features.CQRS.Branches.Delete
{
    public class DeleteBranchCommand : IRequest<DeleteBranchResponse>
    {
        public Guid Id { get; set; }
    }
}
