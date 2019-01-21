using Picks.core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Picks.infrastructure.Repositories.Interfaces
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        Task<Category> GetById(int id);
        Task<IEnumerable<Category>> Get();
    }
}
