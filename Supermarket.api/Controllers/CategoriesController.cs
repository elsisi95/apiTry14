using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Supermarket.api.Domain.Models;
using Supermarket.api.Domain.Services;

namespace Supermarket.api.Controllers
{
    [Route("/api/[controller")] //hena enta bt2ol lel api yrod 3an tare2 route eh
    public class CategoriesController : Controller
    {
        private readonly ICategoryService _categorySrvice;

        public CategoriesController(ICategoryService categoryService)
        {
            _categorySrvice = categoryService;
        }

        [HttpGet]
        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            var categories = await _categorySrvice.ListAsync();
            return categories; 
        }
    }
}