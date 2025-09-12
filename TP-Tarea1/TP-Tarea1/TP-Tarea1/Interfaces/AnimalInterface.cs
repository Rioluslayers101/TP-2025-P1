//Herencia con interfaces

Pajaro miPajaro = new Pajaro();



interface IAnimal
{
    void HacerSonido();
}

interface IVolador
{
    void Volar();
}   



public class Pajaro :Animal , IAnimal, IVolador
{
    public void HacerSonido()
    {
        Console.WriteLine("Pio Pio");
    }
    public void Volar()
    {
        Console.WriteLine("El pajaro esta volando");
    }
}
