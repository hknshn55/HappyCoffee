using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyCoffee.FormUI.Models
{
    public class Order
    {
        public bool State { get; set; }
        public int CategoryId { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
