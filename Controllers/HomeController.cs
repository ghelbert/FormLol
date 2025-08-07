using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FormLol.Models;

namespace FormLol.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Privacy()
    {

        return View();
    }
    [HttpPost]
    public IActionResult Registrar(Jugador jugador)
    {
        if (ModelState.IsValid)
        {
            // Si el modelo es válido, puedes procesarlo (guardar en la base de datos, etc.)
           ViewData["1"] = jugador.Nombre;
           ViewData["2"] = jugador.Edad;
           ViewData["4"] = jugador.FrecuenciaJuego;
           ViewData["3"] = jugador.AñosJugando;
            return View("Index"); // Esto vuelve a mostrar el formulario con el mensaje
        }

        // Si el modelo no es válido, se retorna el formulario con los errores
        return View("Index",jugador);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
