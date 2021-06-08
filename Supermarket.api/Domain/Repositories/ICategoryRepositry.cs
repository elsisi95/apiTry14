using System.Collections.Generic;
using System.Threading.Tasks;
using Supermarket.api.Domain.Models;

namespace Supermarket.api.Domain.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}
