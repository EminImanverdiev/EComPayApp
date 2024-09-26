// Features/Commands/Products/Update/UpdateProductCommandHandler.cs
using AutoMapper;
using EComPayApp.Application.Features.CQRS.Commands.Products.UpdateProduct;
using EComPayApp.Application.Interfaces.Repositories;
using EComPayApp.Application.Interfaces.UoW;
using EComPayApp.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace EComPayApp.Application.Features.CQRS.Commands.Products.Update
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, UpdateProductResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateProductCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<UpdateProductResponse> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var product = await _unitOfWork.Products.GetByIdAsync(request.Id);

            if (product == null)
            {
                return new UpdateProductResponse
                {
                    IsSuccess = false,
                    Message = "Product not found."
                };
            }
            _mapper.Map(request, product);
            var changes = await _unitOfWork.SaveChangesAsync(cancellationToken);

            return new UpdateProductResponse
            {
                IsSuccess = changes > 0,
                Message = changes > 0 ? "Product updated successfully." : "Product update failed.",
                UpdatedDate = DateTime.UtcNow
            };
        }
    }
}
