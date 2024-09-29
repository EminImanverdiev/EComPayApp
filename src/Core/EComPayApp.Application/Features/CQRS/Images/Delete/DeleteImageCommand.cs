using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Application.Features.CQRS.Images.Delete
{
    public class DeleteImageCommand : IRequest<DeleteImageResponse>
    {
        public Guid Id { get; set; }
    }
}
