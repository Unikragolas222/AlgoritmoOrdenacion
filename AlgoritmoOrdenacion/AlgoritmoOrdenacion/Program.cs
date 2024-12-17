// Crear lista de cantidades
List<int> ListaNumeros = new List<int>();

ConsoleKey continuar;
Console.ForegroundColor = ConsoleColor.Blue;

// Crear Do while para pedir mas numeros
do
{
    Console.Clear();
    Console.WriteLine("\nIntroduzca el numero entero que quiera:");
    string respuestaUsuario = Console.ReadLine();
    int cantProd = int.Parse(respuestaUsuario);
    ListaNumeros.Add(cantProd);

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\n¿Desea introducir más numeros? (S/N)");
    continuar = Console.ReadKey().Key;

} while (continuar == ConsoleKey.S);

// Crear lista de numeros ordenada
List<int> ListaNumerosOrdenada = new List<int>();

Console.Clear();

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("\n" + "La lista es esta:" + "\n");
foreach (int numero in ListaNumeros)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write(numero + "\n");
}
Console.WriteLine();

//Pedir al usuario orden descendente o ascendente
Console.WriteLine("\n¿Quieres ordenar la lista en orden ascendente (A) o descendente (D)?");
continuar = Console.ReadKey().Key;

// Crear bucle while con la condición de que response != "A/D"
while (continuar != ConsoleKey.A && continuar != ConsoleKey.D)
{
    Console.WriteLine("\nEsa respuesta no es valida. Por favor haz click en la tecla A/D");
    continuar = Console.ReadKey().Key;
}

// Crear ListOrdQuant
if (continuar == ConsoleKey.D)
{
    // Repetir (con while) hasta que tamaño de ListProdQuant = 0
    while (ListaNumeros.Count != 0)
    {
        // Crear variable MaxCant e inicializar a -1
        int maxQuant = -1;

        // Crear variable MaxPos e inicializar a -1
        int maxPos = -1;

        // Recorrer ListProdQuant: Contar de 0 a tamaño de ListProdQuant y llamar "x"
        for (int x = 0; x < ListaNumeros.Count; x++)
        {
            // Si elemento "x" de ListProdQuant > MaxCant
            if (ListaNumeros[x] > maxQuant)
            {
                // MaxCant = valor de elemento "x" de ListProdQuant
                maxQuant = ListaNumeros[x];

                // MaxPos = x
                maxPos = x;
            }
        }

        // Añadir a ListOrdQuant el elemento MaxPos de ListProdQuant
        ListaNumerosOrdenada.Add(ListaNumeros[maxPos]);

        // Eliminar elemento MaxPos de ListProdQuant
        ListaNumeros.RemoveAt(maxPos);
    }
}
else
{
    // Repetir (con while) hasta que tamaño de ListProdQuant = 0
    while (ListaNumeros.Count != 0)
    {
        // Crear variable MinCant e inicializar a int.MaxValue
        int minQuant = int.MaxValue;

        // Crear variable MinPos e inicializar a -1
        int minPos = -1;

        // Recorrer ListProdQuant: Contar de 0 a tamaño de ListProdQuant y llamar "x"
        for (int x = 0; x < ListaNumeros.Count; x++)
        {
            // Si elemento "x" de ListProdQuant < MinCant
            if (ListaNumeros[x] < minQuant)
            {
                // MinCant = valor de elemento "x" de ListProdQuant
                minQuant = ListaNumeros[x];

                // MinPos = x
                minPos = x;
            }
        }

        // Añadir a ListOrdQuant el elemento MinPos de ListProdQuant
        ListaNumerosOrdenada.Add(ListaNumeros[minPos]);

        // Eliminar elemento MinPos de ListProdQuant
        ListaNumeros.RemoveAt(minPos);
    }
}

Console.Clear();
// Mostrar por pantalla la lista ordenada
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("La lista ordenada quedaría así:\n");
foreach (int numero in ListaNumerosOrdenada)
{
    Console.Write(numero + "\n");
}
Console.WriteLine();
