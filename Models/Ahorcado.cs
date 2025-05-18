namespace TP4_Ku_Hevia.Models;
public static class Ahorcado {

    public static List<string> palabras {get; set;} = new List<string>();
    public static int intentos {get; set;}
    public static string palabraElegida {get; set;} = "";
    public static List<char> letrasUtilizadas{get; set;} = new List<char>();
    public static List<char> letrasCorrectas{get; set;} = new List<char>();

    private static void inicializarVariable() 
    {
        palabras.Add("programacion");
        palabras.Add("java");
        palabras.Add("python");
        palabras.Add("csharp");
        palabras.Add("javascript");
        palabras.Add("html");
        palabras.Add("css");
        palabras.Add("ahorcado");
        palabras.Add("algoritmo");
        palabras.Add("computadora");
        palabras.Add("desarrollador");
        palabras.Add("tecnologia");
        palabras.Add("internet");
        palabras.Add("redes");
        palabras.Add("software");
        palabras.Add("hardware");
        palabras.Add("app");
        palabras.Add("database");
        palabras.Add("framework");
        palabras.Add("algoritmos");
        palabras.Add("codigo");
    }

    public static void comenzarJuego() 
    {
        inicializarVariable();
        Random rd = new Random();
        int rand_num = rd.Next(palabras.Count);
        palabraElegida = palabras[rand_num];
        Console.WriteLine(palabraElegida);
        intentos = 0;
    }
    public static string guionizar(string palabra)
    {
        string guiones = ""; 
            
        foreach(char letra in palabra)
        {
            if (letrasCorrectas.Contains(letra)) 
            {
                guiones += letra;
            }
            else
            {
                guiones += "_";
            }
        }
        return guiones;
    }
}