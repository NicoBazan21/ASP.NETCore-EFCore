using ASP.NET_Core.Models;
using ASP.NET_Core.Models.DBContext;
using ASP.NET_Core.Models.Interfaces;

namespace ASP.NET_Core.Services
{
    public class CategoryService : ICategoryRepository
    {
        private readonly BethanysPieShopDBContext _dbContext;

        public CategoryService(BethanysPieShopDBContext dbContext)
        => _dbContext = dbContext;


        public IEnumerable<Category> GetCategories()
        => this._dbContext.Categories.OrderBy(item => item.CategoryName);
    }
}
