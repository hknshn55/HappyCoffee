using HappyCoffee.Entities.Concrete;
using HappyCoffee.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyCoffee.Business.Abstract
{
    public interface ICategoryService
    {
        Task<List<Category>> CategoryList();
        Task<Category> GetCategoryById(int id);
        Task Update(Category category);
        Task Delete(int id);
        Task Add(CategoryDto categoryDto);
    }
}
