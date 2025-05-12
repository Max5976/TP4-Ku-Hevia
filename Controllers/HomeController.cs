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
        Ahorcado.comenzarJuego();
        ViewBag.palabra = Ahorcado.palabraElegida;
        return View();
    }
    public IActionResult ArriesgarPalabra(string palabra) 
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
        Ahorcado.intentos++;
        return View("JuegoAhorcado");
    }
    public IActionResult ArriesgarLetra(char letra) 
    {
        foreach(char caracter in Ahorcado.palabraElegida)
        {
            if(caracter == letra)
            {
                Ahorcado.letrasCorrectas.Add(letra);
            }
        }
        Ahorcado.intentos++;
        Ahorcado.letrasUtilizadas.Add(letra);
        return View("JuegoAhorcado");
    }
}
