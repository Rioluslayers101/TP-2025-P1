public class Caballero : Guerrero
{
    //Constructir
    public Caballero(string nombre) : base(nombre, 120, 20)
    {
    }
    //Override del metodo atacar
    public override void Atacar(Guerrero enemigo)
    {
        Console.WriteLine($"{Nombre} (Caballero) usa un golpe critico");
        base.Atacar(enemigo);
    }
}