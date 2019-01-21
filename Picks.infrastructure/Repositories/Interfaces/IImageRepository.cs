using Picks.core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Picks.infrastructure.Repositories.Interfaces
{
    public interface IImageRepository : IGenericRepository<Image>
    {
        Task<IEnumerable<Image>> Get();
        Task<IEnumerable<Image>> GetByCategoryId(int categoryId);
    }
}
