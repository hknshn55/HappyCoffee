using HappyCoffee.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyCoffee.Entities.Concrete
{
    public class Category:EntityBase
    {
        public virtual ICollection<Product> Products { get; set; }
    }
}
