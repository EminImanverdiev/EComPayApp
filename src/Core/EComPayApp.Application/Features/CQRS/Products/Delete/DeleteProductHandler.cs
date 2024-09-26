using EComPayApp.Application.Features.CQRS.Commands.Products.DeleteProduct;
using EComPayApp.Application.Interfaces.Repositories;
using EComPayApp.Application.Interfaces.UoW;
using EComPayApp.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace EComPayApp.Application.Features.CQRS.Commands.Products.Delete
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, DeleteProductResponse>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteProductCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<DeleteProductResponse> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var product = await _unitOfWork.Products.GetByIdAsync(request.Id);

            if (product == null)
            {
                return new DeleteProductResponse
                {
                    IsSuccess = false,
                    Message = "Product not found"
                };
            }

            _unitOfWork.Products.Remove(product);
            var changes = await _unitOfWork.SaveChangesAsync(cancellationToken);

            return new DeleteProductResponse
            {
                IsSuccess = changes > 0,
                Message = changes > 0 ? "Product deleted successfully" : "Product deletion failed"
            };
        }
    }
}
