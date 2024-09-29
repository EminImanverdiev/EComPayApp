using AutoMapper;
using EComPayApp.Application.Interfaces.UoW;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Application.Features.CQRS.Orders.Update
{
    public class UpdateOrderCommandHandler : IRequestHandler<UpdateOrderCommand, UpdateOrderResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateOrderCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<UpdateOrderResponse> Handle(UpdateOrderCommand request, CancellationToken cancellationToken)
        {
            var order = await _unitOfWork.Orders.GetByIdAsync(request.Id);

            if (order == null)
            {
                return new UpdateOrderResponse
                {
                    IsSuccess = false,
                    Message = "Order not found."
                };
            }

            _mapper.Map(request, order);
            var changes = await _unitOfWork.SaveChangesAsync(cancellationToken);

            return new UpdateOrderResponse
            {
                IsSuccess = changes > 0,
                Message = changes > 0 ? "Order updated successfully." : "Order update failed.",
                UpdatedDate = DateTime.UtcNow
            };
        }
    }
}
