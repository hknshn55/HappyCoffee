using AutoMapper;
using HappyCoffee.Business.Abstract;
using HappyCoffee.DataAccess.Abstract;
using HappyCoffee.Entities.Concrete;
using HappyCoffee.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyCoffee.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal productDal;
        IMapper mapper;
        public ProductManager(IProductDal productDal,IMapper mapper)
        {
            this.mapper = mapper;
            this.productDal = productDal;
        }



        public async Task Add(ProductDto productDto)
        {
            Product product = mapper.Map<Product>(productDto);
            await productDal.Add(product);
        }





        public async Task Delete(int id)
        {
            Product product = await GetProductById(id);
            await productDal.Delete(product);
        }





        public async Task<Product> GetProductById(int id)
        {
            return await productDal.Get(x=>x.Id == id);
        }





        public async Task<List<Product>> ProductList()
        {
            return await productDal.Products();
        }




        public async Task Update(Product product)
        {
           await productDal.Update(product);
        }
    }
}
