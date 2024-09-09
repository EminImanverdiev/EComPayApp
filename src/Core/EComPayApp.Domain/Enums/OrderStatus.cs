using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Domain.Enums
{
    public enum OrderStatus :int 
    {
        Pending = 0,
        PaymentReceived = 1,
        PaymentFailed = 2
    }
}
