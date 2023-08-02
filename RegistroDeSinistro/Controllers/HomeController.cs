using Microsoft.AspNetCore.Mvc;
using RegistroDeSinistro.Models;
using System.Diagnostics;

namespace RegistroDeSinistro.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Sinistro> model = new List<Sinistro>();
            model.Add(new Sinistro(1, DateTime.Now, "RouboFurto", "Teste", 1, "Bairro", "Curitiba", "PR", "Brasil"));
            model.Add(new Sinistro(2, DateTime.Now, "RouboFurto", "Teste", 1, "Bairro", "Curitiba", "PR", "Brasil"));
            model.Add(new Sinistro(3, DateTime.Now, "RouboFurto", "Teste", 1, "Bairro", "Curitiba", "PR", "Brasil"));
            model.Add(new Sinistro(4, DateTime.Now, "RouboFurto", "Teste", 1, "Bairro", "Curitiba", "PR", "Brasil"));
            model.Add(new Sinistro(5, DateTime.Now, "RouboFurto", "Teste", 1, "Bairro", "Curitiba", "PR", "Brasil"));
            return View(model);
        }

        public IActionResult AddSinistro()
        {
            Sinistro model = new Sinistro();
            return View(model);
        }
        public IActionResult EditSinistro(int id)
        {
            Sinistro model = new Sinistro(1, DateTime.Now, "RouboFurto", "Teste", 1, "Bairro", "Curitiba", "PR", "Brasil");
            return View(model);
        }
        [HttpPost]
        public IActionResult RegistrarSinistro(Sinistro model)
        {
            return RedirectToAction("Index");
        }
         [HttpPost]
        public IActionResult EditarSinistro(Sinistro model)
        {
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}