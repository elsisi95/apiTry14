using System.Collections.Generic;
using System.Threading.Tasks;
using Supermarket.api.Domain.Models;
using Supermarket.api.Domain.Services;
using Supermarket.api.Domain.Repositories;

namespace Supermarket.api.Services
{

    public class CategoryService : ICategoryService
    {
        private readonly ICategoryService _categoryService;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            this._categoryRepository = categoryRepository;
        }
        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _categoryRepository.ListAsync();
        }
    }
}
