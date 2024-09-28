using AutoMapper;
using EComPayApp.Application.DTOs.ProductDtos;
using EComPayApp.Application.Interfaces.Repositories.Products;
using EComPayApp.Application.Interfaces.Services;
using EComPayApp.Application.Interfaces.UoW;
using EComPayApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EComPayApp.Infrastructure.Services
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProductService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IQueryable<ProductListDto>> GetAllProductsAsync()
        {
            var products = _unitOfWork.Products.GetAll(); 
            var productListDtos = _mapper.ProjectTo<ProductListDto>(products);
            return productListDtos;
        }

        public async Task<ProductDto> GetProductByIdAsync(Guid productId)
        {
            var product = await _unitOfWork.Products.GetByIdAsync(productId); 
            return _mapper.Map<ProductDto>(product);
        }

        public async Task<bool> CreateProductAsync(ProductDto createProductDto)
        {
            var product = _mapper.Map<Product>(createProductDto);
            return await _unitOfWork.Products.AddAsync(product);
        }

        public async Task<bool> UpdateProductAsync(ProductDto updateProductDto)
        {
            var product = _mapper.Map<Product>(updateProductDto);
            return _unitOfWork.Products.Update(product);
        }

        public async Task<bool> DeleteProductAsync(Guid productId)
        {
            var product = await _unitOfWork.Products.GetByIdAsync(productId);
            if (product == null)
                return false;

            return _unitOfWork.Products.Remove(product); 
        }
    }
}
