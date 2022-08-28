using HappyCoffee.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyCoffee.Entities.Concrete
{
    public class Product:EntityBase
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Picture { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
