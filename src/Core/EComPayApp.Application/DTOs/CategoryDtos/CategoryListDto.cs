﻿using EComPayApp.Application.Interfaces.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Application.DTOs.CategoryDtos
{
    public  class CategoryListDto:IDto<Guid>
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
