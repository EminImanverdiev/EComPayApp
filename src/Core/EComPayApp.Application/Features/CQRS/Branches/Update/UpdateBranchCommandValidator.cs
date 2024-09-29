using EComPayApp.Application.Features.CQRS.Branches.Delete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Application.Features.CQRS.Branches.Update
{
    public class UpdateBranchCommandValidator : AbstractValidator<UpdateBranchCommand>
    {
        public UpdateBranchCommandValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Branch ID is required.");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Branch name is required.");
            RuleFor(x => x.AddressId).NotEmpty().WithMessage("Address ID is required.");
            RuleFor(x => x.Phone).NotEmpty().WithMessage("Phone number is required.");
            RuleFor(x => x.Email).NotEmpty().EmailAddress().WithMessage("Valid email is required.");
        }
    }
}
