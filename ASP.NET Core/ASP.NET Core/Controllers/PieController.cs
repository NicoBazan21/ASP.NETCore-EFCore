using ASP.NET_Core.Models;
using ASP.NET_Core.Models.Interfaces;
using ASP.NET_Core.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace ASP.NET_Core.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieService;
        private readonly ICategoryRepository _categoryService;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieService = pieRepository;
            _categoryService = categoryRepository;
        }

        /*El ROUTEO funciona de la siguiente manera, se necesita un:
         * 
         *                      {controller}/{action}/{value}
         *                      
         *      {Controller} = Pie de PieController, como la clase
         *      {Action} = lo que devuelve un IActionResult como List en el caso de abajo
         * 
         * Esto coincide por convencion con las carpetas, Pie del controller y List el nombre
         * de la accion que coincide con el archivo cshtml.
         * 
         *      {Value} = puede ser un valor como un id u otra cosa. Siendo en el metodo
         * devolviendo un ViewResult y recibiendo por parametro la variable
         */

        public IActionResult List()
        {
            //ViewBag es un objeto cuyas propiedades son dinamicas, es decir,
            //me sirve para asignarle propiedades fantasia que seran definidas en tiempo de ejecucion
            //para que tambien puedan ser usadas en la Vista/View
            //ViewBag.CurrentCategory = "Cheese cakes";
            //return View(this._pieService.GetPies);
            PieListViewModel pieListViewModel = new PieListViewModel
                (this._pieService.GetPies, "Cheese cakes");
            return View(pieListViewModel);
        }

        public IActionResult Details(Int32 id)
        {
            Pie? pie = this._pieService.GetPieById(id);

            if (pie == null)
                return NotFound();

            return View(pie);

        }
    }
}
