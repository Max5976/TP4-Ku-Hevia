using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP4_Ku_Hevia.Models;

namespace TP4_Ku_Hevia.Controllers;

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
    public IActionResult JuegoAhorcado() 
    {
        ViewBag.palabra = Ahorcado.comenzarJuego();
        return View();
    }
    public IActionResult ArriesgarPalabra(string palabra) 
    {
        return View("JuegoAhorcado");
    }
    public IActionResult ArriesgarLetra(char letra) 
    {
        return View("JuegoAhorcado");
    }
}
