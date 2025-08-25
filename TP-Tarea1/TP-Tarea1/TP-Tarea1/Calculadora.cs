public class Calculadora
{

    //Atributos
    public double Numero1 { get; set; }
    public double Numero2 { get; set; }

    //Atributo privado
    private double Resultado;
    private string Mensaje = "Mensaje privado";

    //Constructores

    public Calculadora(double num1, double num2)
    {
        Numero1 = num1;
        Numero2 = num2;
    }
    //Metodos
    public virtual double Sumar()
    {
        Resultado = Numero1 + Numero2;
        Console.WriteLine($"La suma de {Numero1} y {Numero2} es: {Resultado}");
        return Resultado;
    }
    //SobreCarga de funsion sumar
    public double Sumar(double num3)
    {
        Resultado = Numero1 + Numero2 + num3;
        Console.WriteLine($"La suma es; {Resultado}");
        return Resultado;
    }

    //Sobrecarga del Operador

    public static Calculadora operator + (Calculadora c1, Calculadora c2)
    {
        return new Calculadora(c1.Numero1+c2.Numero1,c1.Numero2+c2.Numero2);
    }
    public void Restar()
    {
        Resultado = Numero1 - Numero2;
        Console.WriteLine($"La resta de {Numero1} y {Numero2} es: {Resultado}");
    }
    public void Multiplicar()
    {
        Resultado = Numero1 * Numero2;
        Console.WriteLine($"La multiplicación de {Numero1} y {Numero2} es: {Resultado}");
    }
    public void Dividir()
    {
        if (Numero2 == 0)
        {
            Console.WriteLine("Error: División por cero no permitida.");
            return;
        }
        Resultado = Numero1 / Numero2;
        Console.WriteLine($"La división de {Numero1} y {Numero2} es: {Resultado}");
    }


    //Metodo privado
    protected string MostrarMensaje()
    {
       Console.WriteLine(Mensaje);
       return Mensaje;
    }
}