//Programa principal de animales

Perro miPerro = new Perro();
miPerro.Respirar();
miPerro.HacerSonido();








public class Animal
{
    //Metodos del padre

    public void Respirar()
    {
        Console.WriteLine("Respirando");
    }

    //Herencia con polimorfismo

    public virtual void HacerSonido()
    {
        Console.WriteLine("El animal hace un sonido");
    }
}


    //Clae fija
    public class Perro : Animal
    {
        public override void HacerSonido()
        {
            Console.WriteLine("Gua Gua");
        }
    }  
    
    public class Gato : Animal
    {
        public override void HacerSonido()
        {
            Console.WriteLine("Miau Miau");
        }
    }

public class  Felinos
{
    public void Garras()
    {
        Console.WriteLine("El felino saca sus garras");
    }
}

