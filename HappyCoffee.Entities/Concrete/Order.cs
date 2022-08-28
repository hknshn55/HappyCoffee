using HappyCoffee.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyCoffee.Entities.Concrete
{
    public class Order:EntityBase
    {
        
        public int CategoryId { get; set; }
        public decimal ProductPrice { get; set; }
        public bool State { get; set; }
        public virtual Product Product { get; set; }
    }
}
