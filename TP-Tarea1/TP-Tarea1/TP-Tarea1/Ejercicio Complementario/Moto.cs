public class Moto : vehiculo
{
    //Constructor
    public Moto(string marca, string modelo) : base(marca, modelo)
    {
    }
    public override void MostrarInfo()
    {
        //base.MostrarInfo();
        Console.WriteLine($"Moto: {Marca} {Modelo}, Velocidad Actual: {VelocidadActual} km/h");
    }
}
