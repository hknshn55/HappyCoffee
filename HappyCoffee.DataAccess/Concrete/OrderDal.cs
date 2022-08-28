using HappyCoffee.Core.DataAccess.Concrete.EntityFrameworkCore;
using HappyCoffee.DataAccess.Abstract;
using HappyCoffee.DataAccess.Concrete.Context;
using HappyCoffee.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyCoffee.DataAccess.Concrete
{
    public class OrderDal:RepositoryBase<Order>,IOrderDal
    {
        public OrderDal(HappyCoffeeContext context):base(context)
        {

        }
    }
}
