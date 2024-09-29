using AutoMapper;
using EComPayApp.Application.Interfaces.UoW;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Application.Features.CQRS.Customers.Update
{
    public class UpdateCustomerCommandValidator : AbstractValidator<UpdateCustomerCommand>
    {
        public UpdateCustomerCommandValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Customer ID is required.");
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("First name is required.");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Last name is required.");
            RuleFor(x => x.Email).NotEmpty().EmailAddress().WithMessage("Valid email is required.");
        }
    }

    // Handler for UpdateCustomerCommand
    public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommand, UpdateCustomerResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateCustomerCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<UpdateCustomerResponse> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = await _unitOfWork.Customers.GetByIdAsync(request.Id);

            if (customer == null)
            {
                return new UpdateCustomerResponse
                {
                    IsSuccess = false,
                    Message = "Customer not found."
                };
            }

            _mapper.Map(request, customer);
            var changes = await _unitOfWork.SaveChangesAsync(cancellationToken);

            return new UpdateCustomerResponse
            {
                IsSuccess = changes > 0,
                Message = changes > 0 ? "Customer updated successfully." : "Customer update failed.",
                UpdatedDate = DateTime.UtcNow
            };
        }
    }
}
