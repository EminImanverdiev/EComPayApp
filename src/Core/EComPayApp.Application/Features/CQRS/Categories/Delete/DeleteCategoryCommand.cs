using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Application.Features.CQRS.Categories.Delete
{
    public class DeleteCategoryCommand : IRequest<DeleteCategoryResponse>
    {
        public Guid Id { get; set; }
    }
}
