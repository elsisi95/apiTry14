using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Supermarket.api.Domain.Models;
using Supermarket.api.Domain.Repositories;
using Supermarket.api.Persistence.Context;

namespace Supermarket.api.Persistence.Repositories
{
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _context.Category.ToListAsync();
        }
    }
}

//the EF core translates our method call to SQL query 
//at this point, we have a clean implementation of the categories controller, 
//the service and repository.

