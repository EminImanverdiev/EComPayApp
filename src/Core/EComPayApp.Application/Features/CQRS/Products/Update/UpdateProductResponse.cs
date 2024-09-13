using EComPayApp.Application.DTOs.ProductDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Application.Features.CQRS.Commands.Products.UpdateProduct
{
    public class UpdateProductResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public GetProductDto Product { get; set; }
    }
}