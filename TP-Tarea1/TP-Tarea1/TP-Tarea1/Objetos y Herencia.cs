using System.Security.Cryptography;

int BASE, ALTURA;
BASE = 50;
ALTURA = 10;

Rectangulo mi_rectangulo = new Rectangulo(BASE, ALTURA);
double area = mi_rectangulo.MostrarArea();
double perimetro = mi_rectangulo.MostrarPerimetro();
Console.WriteLine("El rectangulo tiene las siguientes dimensiones:");
Console.WriteLine($"Base: {mi_rectangulo.Base}, Altura: {mi_rectangulo.Altura}");
Console.WriteLine($"Area: {area}");
Console.WriteLine($"Perimetro: {perimetro}");
Console.WriteLine("--------------------------------------------------");
Cuadrado cuadrado = new Cuadrado(9.5f);
Console.WriteLine($"Base del cuadrado: {cuadrado.Base}");
Console.WriteLine($"Altura del cuadrado: {cuadrado.Altura}");
Console.WriteLine($"Area del cuadrado: {cuadrado.MostrarArea()}");
Console.WriteLine($"Perimetro del cuadrado: {cuadrado.MostrarPerimetro()}");    




