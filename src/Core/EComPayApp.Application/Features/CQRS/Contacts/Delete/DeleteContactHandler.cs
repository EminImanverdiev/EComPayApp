using EComPayApp.Application.Interfaces.UoW;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Application.Features.CQRS.Contacts.Delete
{
    public class DeleteContactCommandHandler : IRequestHandler<DeleteContactCommand, DeleteContactResponse>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteContactCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<DeleteContactResponse> Handle(DeleteContactCommand request, CancellationToken cancellationToken)
        {
            var contact = await _unitOfWork.Contacts.GetByIdAsync(request.Id);

            if (contact == null)
            {
                return new DeleteContactResponse
                {
                    IsSuccess = false,
                    Message = "Contact not found."
                };
            }

            _unitOfWork.Contacts.Remove(contact);
            var changes = await _unitOfWork.SaveChangesAsync(cancellationToken);

            return new DeleteContactResponse
            {
                IsSuccess = changes > 0,
                Message = changes > 0 ? "Contact deleted successfully." : "Contact deletion failed."
            };
        }
    }
}
