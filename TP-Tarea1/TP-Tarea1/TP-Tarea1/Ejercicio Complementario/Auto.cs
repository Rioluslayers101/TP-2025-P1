//Sistema para una agencia de autos Representar un auto que puede acelearar y frenar
public class Auto
{
    //Atributos
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int VelocidadActual { get; set; }

    //Constructor
    public Auto(string marca, string modelo, int velocidadActual)
    {
        Marca = marca;
        Modelo = modelo;
        VelocidadActual = velocidadActual;
    }

    //Metodos
   public void Acelerar(int incremento)
    {
        VelocidadActual += incremento;
        Console.WriteLine($"El auto ha acelerado. Velocidad actual: {VelocidadActual} km/h");
    }

    public void Frenar(int decremento)
    {
        VelocidadActual -= decremento;
        if (VelocidadActual < 0)
        {
            VelocidadActual = 0;
        }
        Console.WriteLine($"El auto ha frenado. Velocidad actual: {VelocidadActual} km/h");
    }
}