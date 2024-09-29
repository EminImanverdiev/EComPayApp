using AutoMapper;
using EComPayApp.Application.Interfaces.UoW;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Application.Features.CQRS.Contacts.Update
{
    public class UpdateContactCommandHandler : IRequestHandler<UpdateContactCommand, UpdateContactResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateContactCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<UpdateContactResponse> Handle(UpdateContactCommand request, CancellationToken cancellationToken)
        {
            var contact = await _unitOfWork.Contacts.GetByIdAsync(request.Id);

            if (contact == null)
            {
                return new UpdateContactResponse
                {
                    IsSuccess = false,
                    Message = "Contact not found."
                };
            }

            _mapper.Map(request, contact);
            var changes = await _unitOfWork.SaveChangesAsync(cancellationToken);

            return new UpdateContactResponse
            {
                IsSuccess = changes > 0,
                Message = changes > 0 ? "Contact updated successfully." : "Contact update failed.",
                UpdatedDate = DateTime.UtcNow
            };
        }
    }
}
