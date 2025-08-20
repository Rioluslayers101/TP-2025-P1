public class Rectangulo
{

    public double Base { get; set; }
    public double Altura { get; set; }

    //Constructor
    public Rectangulo(double baseRec, double AlturaRec)
    {
        Base = baseRec;
        Altura = AlturaRec;
    }

    public virtual double MostrarPerimetro()
    {
        return (Base * 2) + (Altura * 2);
    }
    public virtual double MostrarArea()
    {
        return Base * Altura;
    }

}