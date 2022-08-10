
using HappyCoffee.Core.DataAccess.Concrete.EntityFrameworkCore;
using HappyCoffee.DataAccess.Abstract;
using HappyCoffee.DataAccess.Concrete.Context;
using HappyCoffee.Entities.Concrete;
using HappyCoffee.Entities.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace HappyCoffee.DataAccess.Concrete
{
    public class ProductDal:RepositoryBase<Product>,IProductDal
    {
        public ProductDal(HappyCoffeeContext context):base(context)
        {

        }
        public async Task<List<Product>> Products()
        {    
            return await set.Include(x => x.Category).ToListAsync();
        }
    }
}
