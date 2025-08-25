public class Auto: vehiculo
{
    //Constructor
    public Auto(string marca, string modelo) : base(marca, modelo)
    {
    }

    //Modificar metodo del padre
    public override void MostrarInfo()
    {
        //base.MostrarInfo();
        Console.WriteLine($"Auto: {Marca} {Modelo}, Velocidad Actual: {VelocidadActual} km/h");
    }
}