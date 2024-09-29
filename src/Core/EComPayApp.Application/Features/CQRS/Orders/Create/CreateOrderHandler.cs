using AutoMapper;
using EComPayApp.Application.Interfaces.UoW;
using EComPayApp.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Application.Features.CQRS.Orders.Create
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, CreateOrderResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateOrderCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<CreateOrderResponse> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var order = _mapper.Map<Order>(request);
            await _unitOfWork.Orders.AddAsync(order);

            var changes = await _unitOfWork.SaveChangesAsync(cancellationToken);
            var isSuccess = changes > 0;

            return new CreateOrderResponse
            {
                IsSuccess = isSuccess,
                Message = isSuccess ? "Order created successfully." : "Order creation failed.",
                CreatedDate = DateTime.UtcNow
            };
        }
    }
}
