using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Entities
{
    public class Product:BaseEntity<int>
    {
        public Product()
        {
            
        }
        public Product(string name, string decription,decimal price)
        {
            Name = name;
            Description = decription;
            Price = price;
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
