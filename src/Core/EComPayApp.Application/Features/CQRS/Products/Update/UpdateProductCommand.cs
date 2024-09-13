using EComPayApp.Application.DTOs.ImageDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Application.Features.CQRS.Commands.Products.UpdateProduct
{
    public class UpdateProductCommand : IRequest<UpdateProductResponse>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public float Price { get; set; }
        public Guid CategoryId { get; set; }
        public Guid BranchId { get; set; }
        public ICollection<GetImageDto> Images { get; set; }
    }
    }
