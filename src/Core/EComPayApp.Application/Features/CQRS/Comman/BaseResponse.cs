using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Application.Features.CQRS.Comman
{
    public class BaseResponse<TSuccess,TMessage>
    {
        public TSuccess IsSuccess { get; set; }
        public TMessage Message { get; set; }
    }
}
