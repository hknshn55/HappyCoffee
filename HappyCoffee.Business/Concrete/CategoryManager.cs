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
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal { get; }
        private readonly IMapper _mapper;
        public CategoryManager(ICategoryDal categoryDal, IMapper mapper)
        {

        }
        public async Task Add(CategoryDto categoryDto)
        {
            Category category = _mapper.Map<Category>(categoryDto);
            Category categoryGet =await _categoryDal.Get(x => x.Name == category.Name);
            if (categoryGet == null)
            {
                await _categoryDal.Add(category);
            }
        }

        public async Task<List<Category>> CategoryList()
        {
            return (await _categoryDal.GetAll()).OrderBy(x=>x.Name).ToList();
        }

        public async Task Delete(int id)
        {
            Category category =await GetCategoryById(id);
            await _categoryDal.Delete(category);
        }

        public async Task<Category> GetCategoryById(int id)
        {
            return await _categoryDal.Get(x => x.Id == id);
        }

        public async Task Update(Category category)
        {
            await _categoryDal.Update(category);
        }
    }
}
