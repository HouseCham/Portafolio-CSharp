using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Services;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositorioProyectos repositorioProyectos;

        public HomeController(ILogger<HomeController> logger, IRepositorioProyectos repositorioProyectos)
        {
            _logger = logger;
            this.repositorioProyectos = repositorioProyectos;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Este es un mensaje de log");
            var proyectos = repositorioProyectos.ObtenerProyetos().Take(3).ToList();
            var modelo = new HomeIndexDTO()
            {
                Proyectos = proyectos,
            };
            return View(modelo);
            /* Si View esta vacio, se retornara la vista cuyo nombre sea igual al nombre del metodo (en este caso Index)... 
             * mientras que si se le agrega un parametro ("Index2"), se retornara la vista con ese nombre */
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}