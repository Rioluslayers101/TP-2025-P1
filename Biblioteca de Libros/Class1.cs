namespace Biblioteca_de_Libros
{
    public class libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnioPublicacion { get; set; }

        public libro(string titulo, string autor, int anioPublicacion)
        {
            Titulo = titulo;
            Autor = autor;
            AnioPublicacion = anioPublicacion;
        }
    }

    public class  GestorLibros
    {
        private List<libro> libros = new List<libro>();
        public void AgregarLibro(libro libro)
        {
            libros.Add(libro);
        }

        public void EliminarLibro(string titulo)
        {
            libros.RemoveAll(l => l.Titulo == titulo);
        }

    public List<libro> BuscarLibrosAutor(string autor)
        {
            return libros.FindAll(a => a.Autor == autor);
        }
     
     public void MostrarLibros()
        {
            foreach (libro libro in libros)
            {
                Console.WriteLine($"Título: {libro.Titulo}, Autor: {libro.Autor}, Año de Publicación: {libro.AnioPublicacion}");
            }
        }
    }
}
