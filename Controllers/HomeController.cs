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
        Ahorcado.comenzarJuego();
        return View();
        
    }
    public IActionResult JuegoAhorcado() 
    {
        string guiones = Ahorcado.guionizar(Ahorcado.palabraElegida);
        if (!guiones.Contains("_"))
        {   
            return View("Ganar");
        }   
        else if (Ahorcado.intentos == 6)
        {
            return View("Perder");
        }
        return View();
    }
    public IActionResult ArriesgarPalabra(string palabra) 
    {
        if (string.IsNullOrEmpty(palabra) || palabra.ToLower() != Ahorcado.palabraElegida)
        {
            Ahorcado.intentos++;
            return View("Perder");
        }
        else if (palabra.ToLower() == Ahorcado.palabraElegida)
        {
            return View("Ganar");
        }
        else
        {
            return RedirectToAction("JuegoAhorcado");
        }
    }
    public IActionResult ArriesgarLetra(string letraString) 
    {
        if (string.IsNullOrEmpty(letraString))
        {
            return View("Perder");
        }
        else 
        {
            char letra = char.ToLower(letraString[0]);

            if (Ahorcado.palabraElegida.Contains(letra))
            {
                Ahorcado.letrasCorrectas.Add(letra);
            }
            else
            { 
                Ahorcado.intentos++;
            }

            Ahorcado.letrasUtilizadas.Add(letra);
            return RedirectToAction("JuegoAhorcado");
        }

    }
}
