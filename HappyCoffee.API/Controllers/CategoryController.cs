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
    public class CategoryController : ControllerBase
    {
        public static List<Category> categories = new List<Category>(){ new Category { Id=1,Name="x" }, new Category { Id = 2, Name = "y" }, new Category { Id = 3, Name = "z" } };
      
        //private readonly ICategoryService _categoryService;

        //public CategoryController(ICategoryService categoryService)
        //{
        //    _categoryService = categoryService;
        //}



        [HttpGet]
        public async Task<IActionResult> Categories()
        {
            
            return Ok(categories);
            //var categories = await _categoryService.CategoryList();
            //if (categories != null)
            //{
            //    return Ok(categories);
            //}
            //return NotFound();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Category(int id)
        {
            var ct = categories.Where(x => x.Id == id);
            if (ct!=null)
            {
                return Ok(ct);
            }
            
            
            //if (id > 0)
            //{
            //    var category = await _categoryService.GetCategoryById(id);
            //}
            return BadRequest();
        }

        [HttpPost]
        public async Task<IActionResult> AddCategory(Category category/*CategoryDto categoryDto*/)
        {
            //veri tabanı olmadan basit bir response döndürme kontrolü
            int elemansayisi = categories.Count;
            category.Id = categories.Count + 1;
            categories.Add(category);
            if (elemansayisi < categories.Count)
            {
                return Ok(category);
            }

            //Veri tabanıyla işlem yaparsanız.
            //if (ModelState.IsValid)
            //{
            //    await _categoryService.Add(categoryDto);
            //    return Ok(); // olduğuna dair bilgi versin.
            //}
            return BadRequest();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory([FromBody] Category category)
        {
            
            var ct = categories.FirstOrDefault(x=>x.Id == category.Id);
            if (ct!=null)
            {
                categories.Remove(ct);
                categories.Add(new Category { Id = ct.Id, Name = category.Name, CreateDate = category.CreateDate });
                return Ok(categories.FirstOrDefault(x => x.Id == category.Id));
            }
            return BadRequest("Kullanıcı bulunamadı.");

            //if (ModelState.IsValid)
            //{
            //    await _categoryService.Update(category);
            //    return Ok();
            //}
            //return BadRequest();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory( int id)
        {
            var ct = categories.FirstOrDefault(x => x.Id == id);
            if (ct !=null)
            {
                categories.Remove(ct);
                return Ok(ct);
            }
            return BadRequest();


            //if (id > 0)
            //{
            //    await _categoryService.Delete(id);
            //    return Ok();
            //}
            //return BadRequest();
        }

    }
}
