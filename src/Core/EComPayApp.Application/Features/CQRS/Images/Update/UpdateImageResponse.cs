using EComPayApp.Application.Features.CQRS.Comman;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Application.Features.CQRS.Images.Update
{
    public class UpdateImageResponse : BaseResponse<bool, string>
    {
        public DateTime UpdatedDate { get; set; }
    }
}
