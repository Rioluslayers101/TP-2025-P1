//Listas

//Crear una lista

List<int> numeros = new List<int>();
List<string> nombres = new List<string>();

//Agregar elementos a la lista
numeros.Add(10);
numeros.Add(20);
numeros.Add(30);

//Acceder a elementos de la lista
int primerNumero = numeros[0]; // 10
Console.WriteLine($"Primer numero: {primerNumero}");

//Quitar elementos de la lista
numeros.Remove(20); // Quita el elemento con valor 20
numeros.RemoveAt(0); // Quita el elemento en el índice 0 (10)

//Recorrer la lista
foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}