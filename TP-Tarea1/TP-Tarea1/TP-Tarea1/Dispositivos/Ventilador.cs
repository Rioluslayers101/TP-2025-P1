public class Ventilador : DispositivosPadre
{
    //Atributos
    private int velocidad; //
    //Constructor
    public Ventilador(string nombre, int consumo, int velocidad) : base(nombre, consumo)
    {
        this.velocidad = velocidad;
    }
    //Sobre escritura del metodo MostrarInfo
    public override void MostrarInfo()
    {
        base.MostrarInfo();
        Console.WriteLine($"Velocidad: {velocidad}");
    }
}