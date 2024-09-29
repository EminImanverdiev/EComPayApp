using AutoMapper;
using EComPayApp.Application.Interfaces.UoW;
using EComPayApp.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Application.Features.CQRS.Categories.Create
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, CreateCategoryResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateCategoryCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<CreateCategoryResponse> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = _mapper.Map<Category>(request);
            await _unitOfWork.Categories.AddAsync(category);

            var changes = await _unitOfWork.SaveChangesAsync(cancellationToken);
            var isSuccess = changes > 0;

            return new CreateCategoryResponse
            {
                IsSuccess = isSuccess,
                Message = isSuccess ? "Category created successfully." : "Category creation failed.",
                CreatedDate = DateTime.UtcNow
            };
        }
    }
}
