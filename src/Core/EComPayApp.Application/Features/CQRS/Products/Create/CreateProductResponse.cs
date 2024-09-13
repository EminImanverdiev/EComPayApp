namespace EComPayApp.Application.Features.CQRS.Commands.Products.Create
{
    public class CreateProductResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
