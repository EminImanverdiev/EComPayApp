using AutoMapper;
using EComPayApp.Application.Interfaces.UoW;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Application.Features.CQRS.Images.Update
{
    public class UpdateImageCommandHandler : IRequestHandler<UpdateImageCommand, UpdateImageResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateImageCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<UpdateImageResponse> Handle(UpdateImageCommand request, CancellationToken cancellationToken)
        {
            var image = await _unitOfWork.Images.GetByIdAsync(request.Id);

            if (image == null)
            {
                return new UpdateImageResponse
                {
                    IsSuccess = false,
                    Message = "Image not found."
                };
            }

            _mapper.Map(request, image);
            var changes = await _unitOfWork.SaveChangesAsync(cancellationToken);

            return new UpdateImageResponse
            {
                IsSuccess = changes > 0,
                Message = changes > 0 ? "Image updated successfully." : "Image update failed.",
                UpdatedDate = DateTime.UtcNow
            };
        }
    }

}
