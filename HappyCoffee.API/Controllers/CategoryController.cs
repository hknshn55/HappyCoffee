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
        //private readonly ICategoryService _categoryService;

        //public CategoryController(ICategoryService categoryService)
        //{
        //    _categoryService = categoryService;
        //}



        //[HttpGet]
        //public async Task< IActionResult> Categories()
        //{
        //    var categories = await _categoryService.CategoryList();
        //    if (categories != null)
        //    {
        //        return Ok(categories);
        //    }
        //    return NotFound();
        //}

        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetCategory([FromBody]int id)
        //{
        //    if (id>0)
        //    {
        //        var category = await _categoryService.GetCategoryById(id);
        //    }
        //    return BadRequest();
        //}

        //[HttpPost]
        //public async Task<IActionResult> AddCategory(CategoryDto categoryDto)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        await _categoryService.Add(categoryDto);
        //        return Ok(); // olduğuna dair bilgi versin.
        //    }
        //    return BadRequest();
        //}

        //[HttpPut]
        //public async Task<IActionResult> UpdateCategory([FromBody]Category category)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        await _categoryService.Update(category);
        //        return Ok();
        //    }
        //    return BadRequest();
        //}

        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteCategory([FromBody] int id)
        //{
        //    if (id>0)
        //    {
        //        await _categoryService.Delete(id);
        //        return Ok();
        //    }
        //    return BadRequest();
        //}

    }
}
