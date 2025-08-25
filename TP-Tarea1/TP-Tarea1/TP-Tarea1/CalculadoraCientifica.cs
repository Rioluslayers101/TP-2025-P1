public class CalculadoraCientifica : Calculadora
{
    //Constructor
    public CalculadoraCientifica(double num1, double num2) : base(num1, num2)
    {
    }
    //Metodos

    public override double Sumar()
    {
        double suma= base.Sumar();
        Console.WriteLine($"La suma es {suma*2}");
        return suma;
    }
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
        return factorial;
        }

    public double RaizCuadrada() 
    {
        return Math.Sqrt(Numero1);
        
    }

    public double Logaritmo()
    {
        return Math.Log(Numero1);
    }

// Metodo publico para acceder 
    public void MenCal()
    {
        Console.WriteLine(MostrarMensaje());
    }

}

    