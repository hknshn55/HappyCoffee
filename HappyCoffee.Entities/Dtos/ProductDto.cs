using HappyCoffee.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyCoffee.Entities.Dtos
{
    public class ProductDto:IDto
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Picture { get; set; }
    }
}
