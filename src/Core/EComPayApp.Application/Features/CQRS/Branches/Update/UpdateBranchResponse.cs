using EComPayApp.Application.Features.CQRS.Comman;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Application.Features.CQRS.Branches.Update
{
    public class UpdateBranchResponse : BaseResponse<bool, string>
    {
        public DateTime UpdatedDate { get; set; }
    }
}
