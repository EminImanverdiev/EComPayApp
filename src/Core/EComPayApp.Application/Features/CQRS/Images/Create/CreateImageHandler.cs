using AutoMapper;
using EComPayApp.Application.Interfaces.UoW;
using EComPayApp.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Application.Features.CQRS.Images.Create
{
    public class CreateImageCommandHandler : IRequestHandler<CreateImageCommand, CreateImageResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateImageCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<CreateImageResponse> Handle(CreateImageCommand request, CancellationToken cancellationToken)
        {
            var image = _mapper.Map<Image>(request);
            await _unitOfWork.Images.AddAsync(image);

            var changes = await _unitOfWork.SaveChangesAsync(cancellationToken);
            var isSuccess = changes > 0;

            return new CreateImageResponse
            {
                IsSuccess = isSuccess,
                Message = isSuccess ? "Image created successfully." : "Image creation failed.",
                CreatedDate = DateTime.UtcNow
            };
        }
    }

}
