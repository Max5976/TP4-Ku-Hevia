public static class Ahorcado {

    public static List<string> palabras {get; set;}
    public static int intentos {get; set;}

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
        palabras.Add("código");
    }

    public static string comenzarJuego() 
    {
        inicializarVariable();
        Random rd = new Random();
        int rand_num = rd.Next(palabras.Count - 1);
        string palabraElegida = palabras[rand_num];
        intentos = 0;
        return palabraElegida;
    }
}