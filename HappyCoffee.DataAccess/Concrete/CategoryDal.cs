
using HappyCoffee.Core.DataAccess.Concrete.EntityFrameworkCore;
using HappyCoffee.DataAccess.Abstract;
using HappyCoffee.DataAccess.Concrete.Context;
using HappyCoffee.Entities.Concrete;

namespace HappyCoffee.DataAccess.Concrete
{
    public class CategoryDal:RepositoryBase<Category>,ICategoryDal
    {
        public CategoryDal(HappyCoffeeContext context):base(context)
        {
        }
    }
}
