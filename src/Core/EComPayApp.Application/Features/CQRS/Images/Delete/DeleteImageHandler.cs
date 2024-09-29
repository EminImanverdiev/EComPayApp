using EComPayApp.Application.Interfaces.UoW;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Application.Features.CQRS.Images.Delete
{
    public class DeleteImageCommandHandler : IRequestHandler<DeleteImageCommand, DeleteImageResponse>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteImageCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<DeleteImageResponse> Handle(DeleteImageCommand request, CancellationToken cancellationToken)
        {
            var image = await _unitOfWork.Images.GetByIdAsync(request.Id);

            if (image == null)
            {
                return new DeleteImageResponse
                {
                    IsSuccess = false,
                    Message = "Image not found."
                };
            }

            _unitOfWork.Images.Remove(image);
            var changes = await _unitOfWork.SaveChangesAsync(cancellationToken);

            return new DeleteImageResponse
            {
                IsSuccess = changes > 0,
                Message = changes > 0 ? "Image deleted successfully." : "Image deletion failed."
            };
        }
    }
}
