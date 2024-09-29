using EComPayApp.Application.Features.CQRS.Branches.Delete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Application.Features.CQRS.Branches.Delete
{
    public class DeleteBranchCommandValidator : AbstractValidator<DeleteBranchCommand>
    {
        public DeleteBranchCommandValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Branch ID is required.");
        }
    }
}
