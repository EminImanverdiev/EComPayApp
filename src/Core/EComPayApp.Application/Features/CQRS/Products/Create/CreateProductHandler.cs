using AutoMapper;
using EComPayApp.Application.Features.CQRS.Commands.Products.Create;
using EComPayApp.Application.Features.CQRS.Commands.Products.CreateProduct;
using EComPayApp.Application.Interfaces.UoW;
using EComPayApp.Domain.Entities;
using MediatR;

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
        var product = _mapper.Map<Product>(request);
        await _unitOfWork.Products.AddAsync(product);

        var changes = await _unitOfWork.SaveChangesAsync(cancellationToken);
        var isSuccess = changes > 0; 
        var response = new CreateProductResponse
        {
            IsSuccess = isSuccess,
            Message = isSuccess ? "Product created successfully" : "Product creation failed",
            CreatedDate = DateTime.UtcNow
        };
        return response;
    }
}
