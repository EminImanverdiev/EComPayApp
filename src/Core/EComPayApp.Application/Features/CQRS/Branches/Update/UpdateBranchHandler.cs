using AutoMapper;
using EComPayApp.Application.Features.CQRS.Branches.Delete;
using EComPayApp.Application.Interfaces.UoW;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Application.Features.CQRS.Branches.Update
{
    public class UpdateBranchCommandHandler : IRequestHandler<UpdateBranchCommand, UpdateBranchResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateBranchCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<UpdateBranchResponse> Handle(UpdateBranchCommand request, CancellationToken cancellationToken)
        {
            var branch = await _unitOfWork.Branches.GetByIdAsync(request.Id);

            if (branch == null)
            {
                return new UpdateBranchResponse
                {
                    IsSuccess = false,
                    Message = "Branch not found."
                };
            }

            _mapper.Map(request, branch);
            var changes = await _unitOfWork.SaveChangesAsync(cancellationToken);

            return new UpdateBranchResponse
            {
                IsSuccess = changes > 0,
                Message = changes > 0 ? "Branch updated successfully." : "Branch update failed.",
                UpdatedDate = DateTime.UtcNow
            };
        }
    }
}
