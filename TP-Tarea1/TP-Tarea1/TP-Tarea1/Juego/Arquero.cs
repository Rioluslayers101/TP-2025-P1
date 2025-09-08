//Constructor Arquero
public class Arquero : Guerrero
{
    public Arquero(string nombre) : base(nombre, 90, 15)
    { 
    }
//30% probablidad de fallar
    public override void Atacar(Guerrero enemigo)
    {
        int probabilidad = new Random().Next(0,100);
        if (probabilidad < 30)
        {
            Console.WriteLine($"{Nombre} (Arquero) falla el ataque.");
        }
        else
        {
            Console.WriteLine($"{Nombre} (Arquero) dispara una flecha");
            base.Atacar(enemigo);
        }
    }

}