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
        ViewBag.palabra = Ahorcado.palabraElegida;
        ViewBag.intentos = Ahorcado.intentos;
        return View();
    }
    public IActionResult ArriesgarPalabra(string palabra, int intentos) 
    {
        bool esLaPalabra = false;
        if(palabra == Ahorcado.palabraElegida) 
        {
            esLaPalabra = true;
        }
        else 
        {
            esLaPalabra = false;
        }
        intentos++;
        return View("JuegoAhorcado");
    }
    public IActionResult ArriesgarLetra(char letra, int intentos) 
    {
        Dictionary<int, char> caracteres = new Dictionary<int, char>();
        int i = 0;
        foreach(char caracter in Ahorcado.palabraElegida)
        {
            if(caracter == letra)
            {
                caracteres.Add(i, letra);
            }
            i++;
        }
        intentos++;
        return View("JuegoAhorcado");
    }
}
