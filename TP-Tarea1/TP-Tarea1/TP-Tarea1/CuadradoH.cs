//Cuadrado hereda de rectangulo

public class Cuadrado : Rectangulo
{
    //Lado es tanto la base como la altura
    //Constructor propio para el cuadrado

    public Cuadrado(double lado) : base(lado, lado)
    { 
    }

    //Metodos sobreescribir los heradados de Rectangulo
    public override double MostrarArea()
    {
        return Base * Base;
    }

    public override double MostrarPerimetro()
    {
        return Base * 4;
    }
}
