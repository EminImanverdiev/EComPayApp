using EComPayApp.Application.Features.CQRS.Comman;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Application.Features.CQRS.Customers.Update
{
    public class UpdateCustomerResponse : BaseResponse<bool, string>
    {
        public DateTime UpdatedDate { get; set; }
    }
}
