﻿using EComPayApp.Application.Features.CQRS.Comman;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Application.Features.CQRS.Contacts.Create
{
    public class CreateContactResponse : BaseResponse<bool, string>
    {
        public DateTime CreatedDate { get; set; }
    }
}
