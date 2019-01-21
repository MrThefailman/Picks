using Microsoft.EntityFrameworkCore;
using Picks.core.Entities;
using Picks.infrastructure.Data;
using Picks.infrastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Picks.infrastructure.Repositories.Implementations
{
    public class ImageRepository : GenericRepository<Image>, IImageRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public ImageRepository(ApplicationDbContext dbContext) 
            : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Image>> Get()
        {
            return await Find().ToListAsync();
        }
    }
}
