public class Libro
{
    //Atributos
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string Genero { get; set; }

    protected List<int> Calificaciones;

    //Constructor
    public Libro(string titulo, string autor, string genero)
    {
        Titulo = titulo;
        Autor = autor;
        Genero = genero;
        Calificaciones = new List<int>();
    }
}