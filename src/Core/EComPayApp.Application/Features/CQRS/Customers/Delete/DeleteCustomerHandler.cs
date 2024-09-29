using EComPayApp.Application.Interfaces.UoW;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Application.Features.CQRS.Customers.Delete
{
    public class DeleteCustomerCommandHandler : IRequestHandler<DeleteCustomerCommand, DeleteCustomerResponse>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteCustomerCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<DeleteCustomerResponse> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = await _unitOfWork.Customers.GetByIdAsync(request.Id);

            if (customer == null)
            {
                return new DeleteCustomerResponse
                {
                    IsSuccess = false,
                    Message = "Customer not found."
                };
            }

            _unitOfWork.Customers.Remove(customer);
            var changes = await _unitOfWork.SaveChangesAsync(cancellationToken);

            return new DeleteCustomerResponse
            {
                IsSuccess = changes > 0,
                Message = changes > 0 ? "Customer deleted successfully." : "Customer deletion failed."
            };
        }
    }
}
