using EComPayApp.Application.Interfaces.UoW;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Application.Features.CQRS.Orders.Delete
{
    public class DeleteOrderCommandHandler : IRequestHandler<DeleteOrderCommand, DeleteOrderResponse>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteOrderCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<DeleteOrderResponse> Handle(DeleteOrderCommand request, CancellationToken cancellationToken)
        {
            var order = await _unitOfWork.Orders.GetByIdAsync(request.Id);

            if (order == null)
            {
                return new DeleteOrderResponse
                {
                    IsSuccess = false,
                    Message = "Order not found."
                };
            }

            _unitOfWork.Orders.Remove(order);
            var changes = await _unitOfWork.SaveChangesAsync(cancellationToken);

            return new DeleteOrderResponse
            {
                IsSuccess = changes > 0,
                Message = changes > 0 ? "Order deleted successfully." : "Order deletion failed."
            };
        }
    }
}
