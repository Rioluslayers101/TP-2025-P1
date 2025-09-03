public class PersonaL
{
    //Atributos
    public string Nombre { get; set; }
    public int Edad { get; set; }
    //Constructor
    public PersonaL(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }
    //Metodo
    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}");
    }
}