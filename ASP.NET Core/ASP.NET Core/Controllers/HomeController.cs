using ASP.NET_Core.Models;
using ASP.NET_Core.Models.Interfaces;
using ASP.NET_Core.Services;
using ASP.NET_Core.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace ASP.NET_Core.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieService;

        public HomeController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieService = pieRepository;
        }

        public IActionResult Index()
        {
            IEnumerable<Pie> piesOfTheWeek = this._pieService.PiesOfTheWeek;
            HomeViewModel homeViewModel = new HomeViewModel(piesOfTheWeek);
            return View(homeViewModel);
        }
        
    }
}
