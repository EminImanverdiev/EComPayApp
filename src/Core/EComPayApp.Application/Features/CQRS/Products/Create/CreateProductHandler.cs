using EComPayApp.Application.Interfaces;
using EComPayApp.Application.Features.CQRS.Commands.Products.Create;
using EComPayApp.Domain.Entities;
using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using EComPayApp.Application.Features.CQRS.Commands.Products.CreateProduct;
using EComPayApp.Application.Interfaces.UoW;

namespace EComPayApp.Application.Features.CQRS.Commands.Products.Create
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, CreateProductResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateProductCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<CreateProductResponse> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            // Komandadan Product obyekti yaradılır
            var product = _mapper.Map<Product>(request);

            // Məhsulu əlavə edirik
            await _unitOfWork.Products.AddAsync(product);

            // Əməliyyatları tamamlayırıq
            var isSuccess = await _unitOfWork.SaveChangesAsync(cancellationToken);

            // Cavab obyektini yaradaraq məlumatları doldururuq
            var response = _mapper.Map<CreateProductResponse>(product);
            response.IsSuccess = isSuccess;
            response.Message = isSuccess ? "Product created successfully" : "Product creation failed";
            response.CreatedDate = DateTime.UtcNow;

            return response;
        }
    }
}
