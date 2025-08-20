public class Persona
{
    //Propiedades/ Atributos

    public string Name { get; set; }
    public int Edad { get; set; }

    public static string Pais { get; set; }

    //Constructor

    public Persona(string nombre, int edad)
    {
        Name = nombre;
        Edad = edad;
        
    }

    //Metodos
    public void MostrarDatos()
    {
        Console.Write("Nombre:");
        Console.WriteLine(Name);
        Console.Write("Edad:");
        Console.WriteLine(Edad);
    }
    public static void MostrarPais()
    {
        Console.WriteLine($"Pais:{Pais}");
    }
   
}