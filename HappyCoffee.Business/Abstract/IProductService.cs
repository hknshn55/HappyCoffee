using HappyCoffee.Entities.Concrete;
using HappyCoffee.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyCoffee.Business.Abstract
{
    public interface IProductService
    {
        Task<List<Product>> ProductList();
        Task<Product> GetProductById(int id);
        Task Update(Product product);
        Task Delete(int id);
        Task Add(ProductDto productDto);
    }
}
