using EComPayApp.Application.Features.CQRS.Queries.Products.GetProduct;
using EComPayApp.Application.Interfaces.Repositories;
using EComPayApp.Application.Interfaces.Repositories.IUnitOfWork;
using EComPayApp.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Application.Features.CQRS.Commands.Products.DeleteProduct
{
    public class DeleteProductHandler : IRequestHandler<DeleteProductCommand, DeleteProductResponse>
    {
        private readonly IWriteRepository<Product> _repository;

        public DeleteProductHandler(IWriteRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task<DeleteProductResponse> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var product = await _repository.GetByIdAsync(request.Id);

            if (product == null)
            {
                return new DeleteProductResponse
                {
                    IsSuccess = false,
                    Message = "Product not found"
                };
            }

            var result = _repository.Remove(product);
            await _repository.SaveAsync();

            return new DeleteProductResponse
            {
                IsSuccess = result,
                Message = result ? "Product deleted successfully" : "Delete failed"
            };
        }
    }
}