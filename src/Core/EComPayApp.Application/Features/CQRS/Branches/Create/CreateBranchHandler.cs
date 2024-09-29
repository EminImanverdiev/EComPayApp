using AutoMapper;
using EComPayApp.Application.Interfaces.UoW;
using EComPayApp.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Application.Features.CQRS.Branches.Create
{
    public class CreateBranchCommandHandler : IRequestHandler<CreateBranchCommand, CreateBranchResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateBranchCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<CreateBranchResponse> Handle(CreateBranchCommand request, CancellationToken cancellationToken)
        {
            var branch = _mapper.Map<Branch>(request);
            await _unitOfWork.Branches.AddAsync(branch);

            var changes = await _unitOfWork.SaveChangesAsync(cancellationToken);
            var isSuccess = changes > 0;

            return new CreateBranchResponse
            {
                IsSuccess = isSuccess,
                Message = isSuccess ? "Branch created successfully." : "Branch creation failed.",
                CreatedDate = DateTime.UtcNow
            };
        }
    }
}
