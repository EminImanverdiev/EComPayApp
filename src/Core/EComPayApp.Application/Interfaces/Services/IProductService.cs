using EComPayApp.Application.DTOs.ProductDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Application.Interfaces.Services
{
    public interface IProductService
    {
        Task<IQueryable<ProductListDto>> GetAllProductsAsync();
        Task<ProductDto> GetProductByIdAsync(Guid productId);
        Task<bool> CreateProductAsync(ProductDto createProductDto);
        Task<bool> UpdateProductAsync(ProductDto updateProductDto);
        Task<bool> DeleteProductAsync(Guid productId);
    }
}
