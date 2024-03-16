// Clase 16-03-2024 ================================================================

//FUNCIONES =================================

//Ejem 1 ==============================
static void ejemplo1()
{
    int[] calificaciones;
    calificaciones = new int[] { 85, 92, 77, 68, 94 };
    int i = 0;
    int esuma = 0;
    int enumeros2 = 0;
    foreach (int numeros in calificaciones)
    {
        Console.WriteLine(numeros);
        esuma = numeros + esuma;
    }
    int enumvector = calificaciones.Length;
    double resultado = esuma / enumvector;
    Console.WriteLine($"El promedio de las notas es de: {resultado}\n\n");



    int[] calificaciones2 = { 85, 92, 77, 68, 94, 56, 98, 36, 45, 95 };
    for (int ii = 0; ii < calificaciones2.Length; ii++)
    {
        esuma = calificaciones2[ii] + esuma;
        Console.WriteLine($"Calificación {ii + 1}: {calificaciones2[ii]}");
    }
    resultado = esuma / calificaciones2.Length;
    Console.WriteLine($"El promedio de las notas es de: {resultado}");
}
static void despliegue(int[] arreglo)
{
    foreach (int item in arreglo)
    {
        Console.WriteLine(item);
    }
}
static void ejemplo10()
{
    int[] elementos = new int[] { 50,20,80,90,60 };
    Console.WriteLine($"\n\nOriginal");
    despliegue(elementos);
    Console.WriteLine($"\nOrdenado");
    Array.Sort(elementos);
    despliegue(elementos);
    Console.WriteLine($"\nAl reves");
    Array.Reverse(elementos);
    despliegue(elementos);

    int indice = Array.IndexOf(elementos, 90);
    Console.WriteLine($"{indice}");
    indice = Array.IndexOf(elementos, 105);
    Console.WriteLine($"{indice}");

    bool hayaprobados = Array.Exists(elementos, edgar => edgar >= 59);
    Console.WriteLine(hayaprobados);
}



//Inicio de programa ================================================================

ejemplo1();

ejemplo10();

Console.ReadKey();





