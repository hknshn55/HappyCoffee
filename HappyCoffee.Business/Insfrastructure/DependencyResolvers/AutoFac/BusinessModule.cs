using Autofac;
using HappyCoffee.Business.Abstract;
using HappyCoffee.Business.Concrete;
using HappyCoffee.DataAccess.Abstract;
using HappyCoffee.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyCoffee.Business.Insfrastructure.DependencyResolvers.AutoFac
{
    public class BusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterType<CategoryDal>().As<ICategoryDal>();
            //builder.RegisterType<ProductDal>().As<IProductDal>();

            builder.RegisterType<ProductManager>().As<IProductService>();
            builder.RegisterType<CategoryManager>().As<ICategoryService>();


            base.Load(builder);
        }
    }
}
