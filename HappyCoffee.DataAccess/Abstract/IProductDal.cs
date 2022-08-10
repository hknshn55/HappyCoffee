using HappyCoffee.Core.DataAccess.Abstract;
using HappyCoffee.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyCoffee.DataAccess.Abstract
{
    public interface IProductDal:IRepository<Product>
    {
        Task<List<Product>> Products();
    }
}
