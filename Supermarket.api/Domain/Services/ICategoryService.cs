using System.Collections.Generic;
using System.Threading.Tasks;
using Supermarket.api.Domain.Models;

namespace Supermarket.api.Domain.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
        //ListAsync returns asynchronously an enumeration of categories
    }
}