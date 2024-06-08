using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Entities
{
    public class Category:BaseEntity<int>
    {
        public Category()
        {
            
        }
        public Category(string name,string decription)
        {
            Name = name;
            Description = decription;
        }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
