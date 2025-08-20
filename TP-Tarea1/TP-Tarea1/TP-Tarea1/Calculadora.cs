public class Calculadora
{

    //Atributos
    public double Numero1 { get; set; }
    public double Numero2 { get; set; }
    //Constructores

    public Calculadora(double num1, double num2)
    {
        Numero1 = num1;
        Numero2 = num2;
    }
    //Metodos
    public void Sumar()
    {
        double resultado1 = Numero1 + Numero2;
        Console.WriteLine($"La suma de {Numero1} y {Numero2} es: {resultado1}");
    }
    public void Restar()
    {
        double resultado2 = Numero1 - Numero2;
        Console.WriteLine($"La resta de {Numero1} y {Numero2} es: {resultado2}");
    }
    public void Multiplicar()
    {
        double resultado3 = Numero1 * Numero2;
        Console.WriteLine($"La multiplicación de {Numero1} y {Numero2} es: {resultado3}");
    }
    public void Dividir()
    {
        if (Numero2 == 0)
        {
            Console.WriteLine("Error: División por cero no permitida.");
            return;
        }
        double resultado4 = Numero1 / Numero2;
        Console.WriteLine($"La división de {Numero1} y {Numero2} es: {resultado4}");
    }
}