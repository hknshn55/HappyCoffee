using HappyCoffee.Business.Abstract;
using HappyCoffee.Entities.Concrete;
using HappyCoffee.Entities.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyCoffee.API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ProductController :ControllerBase
    {
        List<Product> products = new List<Product>()
        {
            new Product { Id=1, CategoryId = 1, Name = "Mocca", Price = 5,  Picture ="https://i.nefisyemektarifleri.com/2019/02/17/mocca-1.jpg", Category = new Category{ Id=1,Name="Kahve" } },
             new Product { Id=2, CategoryId = 2, Name = "Expresso", Price = 8,  Picture ="https://d17wu0fn6x6rgz.cloudfront.net/img/w/yazi/mgt/shutterstock_517083931.webp", Category =new Category{ Id=1,Name="Kahve" } },
              new Product { Id=3, CategoryId = 3, Name = "Türk Kahvesi", Price = 100,  Picture ="https://www.citlekci.com.tr/Uploads/UrunResimleri/turk-kahvesi--kahve-8b75.png" , Category = new Category{ Id=1,Name="Kahve" } }
        };

        //private readonly IProductService _productService;

        //public ProductController(IProductService productService)
        //{
        //    _productService = productService;
        //}


        [HttpGet]
        public async Task<IActionResult> Products()
        {
            return Ok(products);
            //var products = await _productService.ProductList();
            //if (products.Count > 0)
            //{
            //    return Ok(products);
            //}
            //return NotFound("Ürün bulunamadı.");


            //Veri tabanı kullanmadan test etmek isterseniz bu şekilde liste oluşturabilirsiniz.
            //List<Product> p = new List<Product>() { new Product { Name="sadas", Price=10, Picture="asdasd", Id=1, Category = new Category { Name="hakan", Id=1 } } };
            //return Ok(p);
        }



        [HttpGet("{id}")]
        public async Task<IActionResult> Product( int id)
        {
            var pr = products.Where(x=>x.Id == id);
            if (pr is not null)
            {
                return Ok(pr);
            }
            return BadRequest();

            //var product = await _productService.GetProductById(id);
            //if (product == null)
            //{
            //    return Ok(product);
            //}
            //return NotFound("Ürün bulunamadı.");
        }



        [HttpPost]
        public async Task<IActionResult> AddProduct(Product product /*ProductDto productDto*/)
        {
            int elemansayisi = products.Count;
            product.Id = products.Count + 1;
            products.Add(product);
            if (elemansayisi < products.Count)
            {
                return Ok(product);
            }
            return NotFound();


            //if (ModelState.IsValid)
            //{
            //    await _productService.Add(productDto);
            //    return Ok();
            //}
            //return BadRequest();
        }


        [HttpPut]
        public async Task<IActionResult> UpdateProduct([FromBody] Product product)
        {
            var pr = products.FirstOrDefault(x => x.Id == product.Id);
            if (pr != null)
            {
                products.Remove(pr);
                products.Add(new Product { Id = pr.Id, Name = product.Name, CreateDate = product.CreateDate });
                return Ok(products.FirstOrDefault(x => x.Id == product.Id));
            }
            return BadRequest();




            //if (ModelState.IsValid)
            //{
            //    await _productService.Update(product);
            //    return Ok();
            //}
            //return BadRequest();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var pr = products.FirstOrDefault(x => x.Id == id);
            if (pr != null)
            {
                products.Remove(pr);
                return Ok(pr);
            }
            return BadRequest();


            //if (id > 0)
            //{
            //    await _productService.Delete(id);
            //    return Ok();
            //}
            //return BadRequest();
        }
    }
}
