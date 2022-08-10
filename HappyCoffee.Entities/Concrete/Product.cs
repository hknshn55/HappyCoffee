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
        public decimal Price { get; set; }
        public string Picture { get; set; }

        public virtual Category Category { get; set; }
    }
}
