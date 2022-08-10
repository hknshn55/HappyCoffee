using HappyCoffee.Business.Abstract;
using HappyCoffee.Business.Concrete;
using HappyCoffee.DataAccess.Abstract;
using HappyCoffee.DataAccess.Concrete;
using HappyCoffee.DataAccess.Concrete.Context;
using Microsoft.EntityFrameworkCore;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyCoffee.Business.Insfrastructure.DependencyResolvers.Ninject
{
    public class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            //Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();
            //Bind<IProductService>().To<ProductManager>().InSingletonScope();

            Bind<IProductDal>().To<ProductDal>();
            Bind<ICategoryDal>().To<CategoryDal>();

            Bind<DbContext>().To<HappyCoffeeContext>();
        }
    }
}
