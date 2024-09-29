using AutoMapper;
using EComPayApp.Application.Interfaces.UoW;
using EComPayApp.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Application.Features.CQRS.Contacts.Create
{
    public class CreateContactCommandHandler : IRequestHandler<CreateContactCommand, CreateContactResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateContactCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<CreateContactResponse> Handle(CreateContactCommand request, CancellationToken cancellationToken)
        {
            var contact = _mapper.Map<Contact>(request);
            await _unitOfWork.Contacts.AddAsync(contact);

            var changes = await _unitOfWork.SaveChangesAsync(cancellationToken);
            var isSuccess = changes > 0;

            return new CreateContactResponse
            {
                IsSuccess = isSuccess,
                Message = isSuccess ? "Contact created successfully." : "Contact creation failed.",
                CreatedDate = DateTime.UtcNow
            };
        }
    }
}
