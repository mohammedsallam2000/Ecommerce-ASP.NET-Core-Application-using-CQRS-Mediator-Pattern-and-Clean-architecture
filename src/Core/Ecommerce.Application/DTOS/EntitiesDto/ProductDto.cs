﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.DTOS.EntitiesDto
{
    public class ProductDto:BaseDto<int>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

    }
}
