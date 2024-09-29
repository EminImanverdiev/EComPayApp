using AutoMapper;
using EComPayApp.Application.Interfaces.UoW;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Application.Features.CQRS.Categories.Update
{
    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommand, UpdateCategoryResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateCategoryCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<UpdateCategoryResponse> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = await _unitOfWork.Categories.GetByIdAsync(request.Id);

            if (category == null)
            {
                return new UpdateCategoryResponse
                {
                    IsSuccess = false,
                    Message = "Category not found."
                };
            }

            _mapper.Map(request, category);
            var changes = await _unitOfWork.SaveChangesAsync(cancellationToken);

            return new UpdateCategoryResponse
            {
                IsSuccess = changes > 0,
                Message = changes > 0 ? "Category updated successfully." : "Category update failed.",
                UpdatedDate = DateTime.UtcNow
            };
        }
    }

}
