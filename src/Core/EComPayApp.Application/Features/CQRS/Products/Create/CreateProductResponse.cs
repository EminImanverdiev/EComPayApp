using EComPayApp.Application.Features.CQRS.Comman;

namespace EComPayApp.Application.Features.CQRS.Commands.Products.Create
{
    public class CreateProductResponse:BaseResponse<bool,string>
    {
        public DateTime CreatedDate { get; set; }
    }
}
