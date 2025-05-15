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
        return View();
    }
    public IActionResult ArriesgarPalabra(string palabra) 
    {
        Ahorcado.intentos++;
        return View("JuegoAhorcado");
    }
    public IActionResult ArriesgarLetra(string letraString) 
    {
        char letra = letraString[0];

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
