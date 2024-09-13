using AutoMapper;
using EComPayApp.Application.DTOs.ProductDtos;
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

namespace EComPayApp.Application.Features.CQRS.Commands.Products.UpdateProduct
{
    public class UpdateProductHandler : IRequestHandler<UpdateProductCommand, UpdateProductResponse>
    {
        private readonly IWriteRepository<Product> _repository;
        private readonly IMapper _mapper;

        public UpdateProductHandler(IWriteRepository<Product> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<UpdateProductResponse> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var product = await _repository.GetByIdAsync(request.Id);

            if (product == null)
            {
                return new UpdateProductResponse
                {
                    IsSuccess = false,
                    Message = "Product not found"
                };
            }

            _mapper.Map(request, product);

            var result = _repository.Update(product);
            await _repository.SaveAsync();

            return new UpdateProductResponse
            {
                IsSuccess = true,
                Message = "Product updated successfully",
                Product = _mapper.Map<GetProductDto>(product)
            };
        }
    }
    }
