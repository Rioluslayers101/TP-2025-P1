using Biblioteca_de_Libros;

namespace ExtensionesBiblioteca
{
    public static class LibroExtensiones
    {
        public static string InformacionLibro(this libro libro)
        {
            return $"{libro.Titulo} por {libro.Autor}, publicado en {libro.AnioPublicacion}.";

        }

        public static bool EsLibroClasico(this libro libro)
        {
            return (DateTime.Now.Year - libro.AnioPublicacion) > 50;
        }
    }
}
