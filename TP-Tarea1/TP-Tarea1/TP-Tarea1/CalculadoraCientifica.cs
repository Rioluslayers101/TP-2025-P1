public class CalculadoraCientifica : Calculadora
{
    //Constructor
    public CalculadoraCientifica(double num1, double num2) : base(num1, num2)
    {
    }
    //Metodos
    public int Factorial()
    {
        int factorial = 1;

        if (Numero1 <0)
        {
            Console.WriteLine("El numero no tiene factorial");
            return 0;
        }
        for (int i = 1; i <= Numero1; i++)
            {
                factorial=factorial*i;
            }
            Console.WriteLine($"El factorial de {factorial} es: {resultado}");
        }
    }

    