using ASP.NET_Core.Models;

namespace ASP.NET_Core.ViewModels
{
    public class PieListViewModel
    {
        public IEnumerable<Pie> Pies { get; }
        public String? CurrentCategory { get; }

        public PieListViewModel(IEnumerable<Pie> pies, String? currentCategory)
        {
            Pies = pies;
            CurrentCategory = currentCategory;
        }
    }
}
