//Arreglos
//Inicialización

int[] numeros = new int[3];

//Asignar valores  a elementos
numeros[0] = 0;
numeros[1] = 2;
numeros[2] = 4;

for (int i=0; i<=2; i++)
{
    Console.WriteLine(numeros[i]);
}

foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}

if (numeros[1] == 2)
{
    Console.WriteLine("El valor es 2");
}

//Obtenener la longitud del arreglo
Console.WriteLine(numeros.Length);

//Definicion implicita
int[] numeros2 = new int[10] {3, 4, 1, 2, 7, 5, 8, 9, 11,12};
char [] vocales = new char[] {'a', 'e', 'i', 'o', 'u'};

foreach (char vocal in vocales)
{ 
    Console.WriteLine(vocal);
}

bool[] estados = new bool[3];
estados[0] = true;
estados[1] = false;
estados[2] = true;

if (estados[2])
{
    Console.WriteLine("El estado es verdadero");
}

//Ordenamiento de menor a mayor
Console.WriteLine("Arreglo desordenado");

foreach (int numero2 in numeros2)
{
    Console.WriteLine(numero2);
}

Array.Sort(numeros2);
Console.WriteLine("Arreglo ordenado");
foreach (int numero2 in numeros2)
{
    Console.WriteLine(numero2);
}

//Arrgelo ordenado de mayor a menor
//Necesairo mi arreglo ya previamente de menor a mayor
Array.Reverse(numeros2);
Console.WriteLine("Arreglo ordenado de mayor a menor");
    foreach (int numero2 in numeros2)
{
    Console.WriteLine(numero2);
}
//Busqueda por valor
Console.WriteLine(Array.BinarySearch(numeros2, 7));