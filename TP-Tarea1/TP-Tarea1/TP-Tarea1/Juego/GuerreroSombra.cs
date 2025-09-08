public class GuerreroSombra : Guerrero
{
    //Constructor
    public GuerreroSombra(string nombre) : base(nombre, 110, 22)
    {
    }
    //Override del metodo atacar
    public override void Atacar(Guerrero enemigo)
    {
        Console.WriteLine($"{Nombre} (Guerrero Sombra) ataca desde las sombras");
        base.Atacar(enemigo);
    }

    //Override del metodo recibir daño con 20% de probabilidad de esquivar
    public override void RecibirDanio(int danio)
    {
        int probabilidad = new Random().Next(0, 100);
        if (probabilidad < 20)
        {
            Console.WriteLine($"{Nombre} (Guerrero Sombra) esquiva el ataque.");
        }
        else
        {
            base.RecibirDanio(danio);
        }
    }
}