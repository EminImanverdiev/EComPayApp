using EComPayApp.Application.Features.CQRS.Branches.Delete;
using EComPayApp.Application.Interfaces.UoW;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Application.Features.CQRS.Branches.Delete
{
    public class DeleteBranchCommandHandler : IRequestHandler<DeleteBranchCommand, DeleteBranchResponse>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteBranchCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<DeleteBranchResponse> Handle(DeleteBranchCommand request, CancellationToken cancellationToken)
        {
            var branch = await _unitOfWork.Branches.GetByIdAsync(request.Id);

            if (branch == null)
            {
                return new DeleteBranchResponse
                {
                    IsSuccess = false,
                    Message = "Branch not found."
                };
            }

            _unitOfWork.Branches.Remove(branch);
            var changes = await _unitOfWork.SaveChangesAsync(cancellationToken);

            return new DeleteBranchResponse
            {
                IsSuccess = changes > 0,
                Message = changes > 0 ? "Branch deleted successfully." : "Branch deletion failed."
            };
        }
    }
}
