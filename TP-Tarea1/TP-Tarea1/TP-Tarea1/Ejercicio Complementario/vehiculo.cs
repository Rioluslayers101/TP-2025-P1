public class vehiculo
{
    //Sistema para una agencia de autos Representar un auto que puede acelearar y frenar

    //Atributos
    /* public string Marca { get; set; }
     public string Modelo { get; set; }
     public int VelocidadActual { get; set; }*/

    //Atributos privados para que no se puedan modificar directamente
    protected string marca;
    protected string modelo;
    protected int velocidadActual;

    //Propiedades publiacs con control
    public string Marca
    {
        get { return marca; }
        set { marca = value; }
    }

    public string Modelo
    {
        get { return modelo; }
        set { modelo = value; }
    }

    public int VelocidadActual
    {
        get { return velocidadActual; }
        private set
        {
            if (velocidadActual < 0)
            {
                velocidadActual = 0;
            }
            else
            {
                velocidadActual = value;
            }
        }
    }


    //Constructor
    public vehiculo(string marca, string modelo)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.velocidadActual = 0; // Inicializa la velocidad actual a 0
    }
    


    //Metodos
    public void Acelerar(int incremento)
    {
        VelocidadActual += incremento;
    }

    //Sobrecargar del metodo sin parametros

    public void Acelerar()
    {
        VelocidadActual += 10; // Incremento por defecto
        Console.WriteLine($"El auto aceleró: {VelocidadActual} km/h");
    }

    public void Frenar(int decremento)
    {
        VelocidadActual -= decremento;
        if (VelocidadActual < 0)
        {
            VelocidadActual = 0;
        }
    }

    public void Frenar()
    {
        VelocidadActual -= 10; // Decremento por defecto
    }

    //Metodo para mostrar informacion del vehiculo
    public virtual void MostrarInfo()
    {
        Console.WriteLine($"Vehiculo: {marca} {modelo}, Velocidad Inicial: {VelocidadActual} km/h");

    }

    //Sobrecarga de operadores
    public static bool operator >(vehiculo v1, vehiculo v2)
    {
        return v1.VelocidadActual > v2.VelocidadActual;
    }

    public static bool operator <(vehiculo v1, vehiculo v2)
    {
        return v1.VelocidadActual < v2.VelocidadActual;
    }

    public static bool operator ==(vehiculo v1, vehiculo v2)
    {
        return v1.VelocidadActual == v2.VelocidadActual;
    }

    public static bool operator !=(vehiculo v1, vehiculo v2)
    {
        return v1.VelocidadActual != v2.VelocidadActual;
    }
}