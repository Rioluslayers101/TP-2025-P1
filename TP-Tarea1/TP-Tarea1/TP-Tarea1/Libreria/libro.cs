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

    //Metodos
    public void Calificar(int nota)
    {
        if(nota<1 || nota>5)
        {
            throw new ArgumentException("Calificación invalida (debe estar entre 1 y 5");
        }
        Calificaciones.Add(nota);
    }

    //Sobrecargar
    public void Calificar(int nota,string comentario)
    {
     Console.WriteLine($"Comentario recibido: {comentario}");
     Calificar(nota);
    }

    public double ObtenerPromedio()
    {
        if(Calificaciones.Count==0)
        {
            return 0;
        }
        double suma=0;
        foreach(int calificacion in Calificaciones)
        {
            suma+=calificacion;
        }
        return suma/Calificaciones.Count;
    }
    public int ObtenerCantidadVotos()
    {
        return Calificaciones.Count;
    }
}

//Subclases para las diferentes categorias de libros
public class LibroFiccion:Libro
{
    public LibroFiccion(string titulo, string autor, string genero):base(titulo,autor,genero)
    {
    }
}

public class LibroTecnico:Libro
{
    public LibroTecnico(string titulo, string autor, string genero):base(titulo,autor,genero)
    {
    }
}

//Interfaz para la seleccion de estrategias de recomendacion

interface IRecomendable
{

    Libro ObtenerMejorLibro(List<Libro> libros);
}
//Estrategia basada en el promedio de calificaciones



public class RecomendacionPorPromedio:IRecomendable
{
    public Libro ObtenerMejorLibro(List<Libro> libros)
    {
        if(libros==null || libros.Count==0)
        {
            throw new ArgumentException("La lista de libros no puede estar vacia");
        }
        Libro mejorLibro=null;
        double mejorPromedio= -1;
        foreach(var libro in libros)
        {
            double promedio=libro.ObtenerPromedio();
            if(promedio>mejorPromedio)
            {
                mejorPromedio=promedio;
                mejorLibro=libro;
            }
        }
        return mejorLibro;
    }
}
//Estrategia basada en la cantidad de votos
public class RecomendacionPorVotos:IRecomendable
{
    public Libro ObtenerMejorLibro(List<Libro> libros)
    {
        if(libros==null || libros.Count==0)
        {
            throw new ArgumentException("La lista de libros no puede estar vacia");
        }
        Libro mejorLibro=null;
        int mayorCantidadVotos=-1;
        foreach(var libro in libros)
        {
            int cantidadVotos=libro.ObtenerCantidadVotos();
            if(cantidadVotos>mayorCantidadVotos)
            {
                mayorCantidadVotos=cantidadVotos;
                mejorLibro=libro;
            }
        }
        return mejorLibro;
    }
}

//Clase para libreria
public class Libreria
{
    private List<Libro> libros = new List<Libro>();
    private IRecomendable estrategiaRecomendacion = new RecomendacionPorPromedio();

    private readonly string[] generoFiccion = {"Ciencia Ficción", "Fantasia", "Romance", "Misterio","Horror","Novela" };
    private readonly string[] generoTecnico = {"ED diferenciales", "Termodinamica", "Mecanica de Fluidos", "Negocios","Algebra Lineal","Calculo Vectorial" };

    //Medotodos de la libreria
    public void AgregarLibro(string titulo,string autor,string genero)
    {
        if(generoFiccion.Contains(genero))
        {
            libros.Add(new LibroFiccion(titulo,autor,genero));
        }
        else if(generoTecnico.Contains(genero))
        {
            libros.Add(new LibroTecnico(titulo,autor,genero));
        }
        else
        {
            throw new ArgumentException("Genero no reconocido");
        }
    }

    public void CalificarLibro(string titulo,int nota)
    {
        Libro LibroEncontrado = null;
        foreach(var libro in libros)
        {
            if(libro.Titulo == titulo)
            {
                LibroEncontrado=libro;
                break;
            }
        }
        if (LibroEncontrado == null)
        {
            throw new ArgumentException("Libro no encontrado");
        }
        else if (LibroEncontrado != null)
        {
            LibroEncontrado.Calificar(nota);
        }
    }

    //Sobrecarga del metodo CalificarLibro
    public void CalificarLibro(string titulo, int nota, string comentario = "")
    {
        Libro LibroEncontrado = null;
        foreach (var libro in libros)
        {
            if (libro.Titulo == titulo)
            {
                LibroEncontrado = libro;
                break;
            }
        }
        if (LibroEncontrado == null)
        {
            throw new ArgumentException("Libro no encontrado");
        }
        else if (LibroEncontrado != null)
        {
            LibroEncontrado.Calificar(nota, comentario);
        }
    }
    //Criterio de calificacion
    public void CambiarCriterio(string criterio)    
    {
        if(criterio=="Promedio")
        {
            estrategiaRecomendacion=new RecomendacionPorPromedio();
        }
        else if(criterio=="Votos")
        {
            estrategiaRecomendacion=new RecomendacionPorVotos();
        }
        else
        {
            throw new ArgumentException("Criterio no reconocido");
        }
    }
    //Mejor libro
}