using Asp.NetMvcApp.Data;
using Asp.NetMvcApp.Interfaces;
using Asp.NetMvcApp.Models;

namespace Asp.NetMvcApp.Repository
{
    public class CategoryRepository : ICarsCategory
    {
        private readonly AppDbContext _dbContext;
        public CategoryRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Category> AllCategories => _dbContext.Category;
    }
}
