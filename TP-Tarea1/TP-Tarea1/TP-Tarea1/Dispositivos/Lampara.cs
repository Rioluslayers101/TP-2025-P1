public class Lampara : DispositivosPadre
{
    //Atributos
    private int brillo; // Nivel de brillo de la lámpara (0-100)
    //Constructor
    public Lampara(string nombre, int consumo, int brillo) : base(nombre, consumo)
    {
        this.brillo = brillo;
    }
    //Sobre escritura del metodo MostrarInfo
    public override void MostrarInfo()
    {
        base.MostrarInfo();
        Console.WriteLine($"Brillo: {brillo}%");
    }
}