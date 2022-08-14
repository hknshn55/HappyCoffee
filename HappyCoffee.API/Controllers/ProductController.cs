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
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }


        [HttpGet]
        
        public async Task<IActionResult> Products()
        {
            var products = await _productService.ProductList();
            if (products.Count > 0)
            {
                return Ok(products);
            }
            return NotFound("Ürün bulunamadı.");


            //Veri tabanı kullanmadan test etmek isterseniz bu şekilde liste oluşturabilirsiniz.
            //List<Product> p = new List<Product>() { new Product { Name="sadas", Price=10, Picture="asdasd", Id=1, Category = new Category { Name="hakan", Id=1 } } };
            //return Ok(p);
        }



        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct([FromBody] int id)
        {
            var product = await _productService.GetProductById(id);
            if (product == null)
            {
                return Ok(product);
            }
            return NotFound("Ürün bulunamadı.");
        }



        [HttpPost]
        public async Task<IActionResult> AddProduct(ProductDto productDto)
        {
            if (ModelState.IsValid)
            {
                await _productService.Add(productDto);
                return Ok();
            }
            return BadRequest();
        }


        [HttpPut]
        public async Task<IActionResult> UpdateProduct([FromBody] Product product)
        {
            if (ModelState.IsValid)
            {
                await _productService.Update(product);
                return Ok();
            }
            return BadRequest();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromBody] int id)
        {
            if (id > 0)
            {
                await _productService.Delete(id);
                return Ok();
            }
            return BadRequest();
        }
    }
}
