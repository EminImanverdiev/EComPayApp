using EComPayApp.Application.Interfaces.UoW;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Application.Features.CQRS.Categories.Delete
{
    public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommand, DeleteCategoryResponse>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteCategoryCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<DeleteCategoryResponse> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = await _unitOfWork.Categories.GetByIdAsync(request.Id);

            if (category == null)
            {
                return new DeleteCategoryResponse
                {
                    IsSuccess = false,
                    Message = "Category not found."
                };
            }

            _unitOfWork.Categories.Remove(category);
            var changes = await _unitOfWork.SaveChangesAsync(cancellationToken);

            return new DeleteCategoryResponse
            {
                IsSuccess = changes > 0,
                Message = changes > 0 ? "Category deleted successfully." : "Category deletion failed."
            };
        }
    }
}
