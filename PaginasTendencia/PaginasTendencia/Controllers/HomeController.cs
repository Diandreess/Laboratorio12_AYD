using Microsoft.AspNetCore.Mvc;
using PaginasTendencia.Models;
using System.Diagnostics;
using Persistencia;
using ModeloDatos;
using System.Diagnostics.CodeAnalysis;

namespace PaginasTendencia.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string campoBusqueda)
        {
            ConexionBD conexion = new ConexionBD();
            Pagina busqueda = conexion.ObtenerPagina($"'{campoBusqueda}'");
            return RedirectToAction("PaginaVista", busqueda);
        }

        [HttpGet]
        public IActionResult PaginaVista(Pagina pagina)
        {
            return View(pagina);
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