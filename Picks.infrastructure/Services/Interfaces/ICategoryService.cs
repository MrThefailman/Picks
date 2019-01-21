using Picks.infrastructure.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Picks.infrastructure.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryViewModel>> Get();
        Task<CategoryViewModel> GetById(int id);
        Task<int> Add(CategoryViewModel vm);
    }
}
