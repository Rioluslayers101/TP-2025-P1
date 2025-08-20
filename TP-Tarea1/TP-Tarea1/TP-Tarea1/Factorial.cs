Console.WriteLine("Ingrese un número para calcular su factorial:");
int factorial = int.Parse(Console.ReadLine()??"");

if (factorial <=1)
{
    Console.WriteLine("El numero no tiene factorial");
}
else
{
    int resultado = 1;
    for (int i = 2; i <= factorial; i++)
    {
        resultado *= i;
    }
    Console.WriteLine($"El factorial de {factorial} es: {resultado}");
}