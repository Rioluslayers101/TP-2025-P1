using Biblioteca_de_Libros;
using ExtensionesBiblioteca;
GestorLibros gestorLibros = new GestorLibros();


//Agregar Libro
gestorLibros.AgregarLibro(new libro("Los de Abajo", "George Orwell", 1915));
gestorLibros.AgregarLibro(new libro("Cien años de soledad", "Garcia Marquez", 1961));
gestorLibros.AgregarLibro(new libro("Don Quijote", "Miguel Cervantes", 1605));
gestorLibros.AgregarLibro(new libro("El gato negro", "Edgar Allan Poe", 1843));
gestorLibros.AgregarLibro(new libro("Cien años de soledad", "Garcia Marquez", 2004));

//Mostrar libros
Console.WriteLine("Libros en la biblioteca:");
gestorLibros.MostrarLibros();

//Eliminar libro
Console.WriteLine("Escribe el titulo a descatar:");
string titulo = Console.ReadLine()??"";

gestorLibros.EliminarLibro(titulo);

//Buscar autor
Console.WriteLine("Escribe el autor a buscar:");
string autor = Console.ReadLine()??"";
List<libro> librosAutor = gestorLibros.BuscarLibrosAutor(autor);
foreach (var libro in librosAutor)
{
    Console.WriteLine(libro.Titulo);
}

//Usar metodos de extension
var libroN = gestorLibros.BuscarLibrosAutor("Edgar Allan Poe")[0];
Console.WriteLine("Informacion de libro:");
Console.WriteLine(libroN.InformaciónLibro());
Console.WriteLine("Es libro clasico: " + libroN.EsLibroClasico());

//Validaciones
Console.WriteLine("Validaciones");
Console.WriteLine("Es un año valido" + Validaciones EsNaioValido(libroN.AnioPublicacion));