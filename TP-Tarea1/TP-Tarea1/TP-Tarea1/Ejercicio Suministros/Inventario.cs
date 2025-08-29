public class Inventario
{
    //Atributo
    private Suministro[] suministros;

    //Constructor
    public Inventario()
    {
        suministros = new Suministro[0];
        {
            new Suministro("Comida", 5, 1);
            new Suministro("Agua", 10, 1);
            new Suministro("Ropa", 7, 2);
            new Suministro("Medicinas", 0, 1);
            new Suministro("Herrmientas");
            new Suministro("Oxigeno");
            new Suministro("Combustible");

        }
    }

    //Metodos
    public void MostrarSuministros()
    {
        Console.WriteLine("Suministros en el inventario:");
        foreach (Suministro item in suministros)
        {
            item.MostrarInfo();
        }

    }


    public void BuscarSuministro(string nombre)
    {
        int indice = Array.FindIndex(suministros, itemB => itemB.Nombre.ToLower() == nombre.ToLower());
        if (indice >=0)
        { 
          Console.WriteLine($"{nombre} encontrado en la posición {indice}");
        }
        else
        {
            Console.WriteLine($"{nombre} no esta en el inventario");
        }
    }

    //Orednar suministro por nombre
    public void OrdenarPorNombre()
    {
        Array.Sort(suministros,(x,y) => x.Nombre.CompareTo(y.Nombre));
        Console.WriteLine("El inventario ha sido ordenado por nombre");
    }

    //Invertir el orden
    public void InvertirOrden()
    {
        Array.Reverse(suministros);
        Console.WriteLine("El orden del inventario ha sido invertido");
    }


    //Vaciar inventario
    public void VaciarInventario()
    {
        Array.Clear(suministros,0,suministros.Length);
        Console.WriteLine("El inventario ha sido vaciado");
        Console.WriteLine($"El inventario tiene {suministros.Length} suministros");
    }

    //Agregar  suministro 3 parametros
    public void AgregarSuministro(string nombre, int cantidad, int prioridad)
    {

        int indice = Array.FindIndex(suministros, itemB => itemB.Nombre.ToLower() == nombre.ToLower());
        if (indice >= 0)
        {

            Console.WriteLine($"Ya existe {nombre} encontrado en la posición {indice}");
        }
        else
        {
            Array.Resize(ref suministros, suministros.Length + 1);
            suministros[suministros.Length - 1] = new Suministro(nombre, cantidad, prioridad);
            Console.WriteLine($"{nombre} ha sido agregado al inventario");
        }
    }

    //Agregar suministro unicamente con nombre
    public void AgregarSuministro(string nombre)
    {
        AgregarSuministro(nombre, 1, 2);

    }

    //Eliminar suministro
    public void EliminarSuministro(string nombre)
    {
        int indice = Array.FindIndex(suministros, itemB => itemB.Nombre.ToLower() == nombre.ToLower());
        if (indice >= 0)
        {
            for (int i = indice; i < suministros.Length - 1; i++)
            {
                suministros[i] = suministros[i + 1];
            }
            Array.Resize(ref suministros, suministros.Length - 1);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{nombre} ha sido eliminado del inventario");
        }
        else
        {
        Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{nombre} no esta en el inventario");
        }
    }
}