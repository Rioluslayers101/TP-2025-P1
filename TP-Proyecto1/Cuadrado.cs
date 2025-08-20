public class Cuadrado
{
    //Atributos (lados)
    //Constructor (asignar valor de lados)
    //Metodos(muestre perimetro, muestre area)

    //ATRIBUTOS
    public float Lado {  get; set; }

    //Constructor
    public Cuadrado(float lado) { 
       Lado = lado;   
    }

    public void MostrarPerimetro() {
        Console.WriteLine($"Su perimetro es:{4*Lado}");
    }
    public void MostrarArea() {
        Console.WriteLine($"Su area es:{Lado*Lado}");

    }

}   