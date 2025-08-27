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
}