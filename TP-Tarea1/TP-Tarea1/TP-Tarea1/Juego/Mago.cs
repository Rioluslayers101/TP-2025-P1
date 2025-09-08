//Mago
public class Mago : Guerrero
{
    //Constructir
    public Mago(string nombre) : base(nombre, 80, 25)
    {
    }
    //Override del metodo atacar
    public override void Atacar(Guerrero enemigo)
    {
        Console.WriteLine($"{Nombre} (Mago) lanza hechizo de fuego");
        base.Atacar(enemigo);
    }
}