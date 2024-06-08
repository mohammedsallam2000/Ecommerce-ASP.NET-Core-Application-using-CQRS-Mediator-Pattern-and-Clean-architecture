using Ecommerce.Application.DTOS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.DTOS.EntitiesDto
{
    public class CategoryDto:BaseDto<int>
    {
        public string Name { get; set; }

    }
}
