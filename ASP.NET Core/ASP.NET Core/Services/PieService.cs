using ASP.NET_Core.Models;
using ASP.NET_Core.Models.DBContext;
using ASP.NET_Core.Models.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_Core.Services
{
    public class PieService : IPieRepository
    {
        private readonly BethanysPieShopDBContext _dbContext;

        public PieService(BethanysPieShopDBContext context)
        => this._dbContext = context;

        public IEnumerable<Pie> GetPies
        {
            get
            {
                return this._dbContext.Pies.Include(item => item.Category);
            }
        }

        public IEnumerable<Pie> PiesOfTheWeek
        {
            get
            {
                return this._dbContext.Pies
                    .Include(item => item.Category) 
                    .Where(item => item.IsPieOfTheWeek);
            }
        }

        public Pie? GetPieById(int id)
        => this._dbContext.Pies.FirstOrDefault(item => item.PieId == id);

    }
}
