//Pograma principal del inventario MiSION Orion x

// Instanciar Inventario

Inventario inventario = new Inventario();
bool salir = false;

do
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("\n--- Menú de Inventario de Suministros ---");
    Console.WriteLine("1-Agregar Suministros");
    Console.WriteLine("2-Buscr Suministros");
    Console.WriteLine("3-Eliminar Suministros");
    Console.WriteLine("4-Mostrar Inventario");
    Console.WriteLine("5-Limpiar Suministros");
    Console.WriteLine("6-Salir");

    int opcion = int.Parse(Console.ReadLine() ?? "");

    switch (opcion)
    {
        case 1:
            Console.WriteLine("Escribre el nombre del suministro a agregar:");
            string nombre = Console.ReadLine() ?? "";
            if (nombre != "")
            {
                Console.WriteLine("Quieres asignar cantidad y prioridad");
                Console.WriteLine("1-Si");
                Console.WriteLine("2-No");
                int respuesta = int.Parse(Console.ReadLine() ?? "");
                switch (respuesta)
                {
                    case 1:
                        Console.WriteLine("Escribe la cantidad:");
                        int cantidad = int.Parse(Console.ReadLine() ?? "");
                        Console.WriteLine("Escribe la prioridad (1-Alta, 2-Media, 3-Baja):");
                        int prioridad = int.Parse(Console.ReadLine() ?? "");
                        inventario.AgregarSuministro(nombre, cantidad, prioridad);
                        break;

                    case 2:
                        inventario.AgregarSuministro(nombre);
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Suministro no agregado.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("El nombre no puede estar vacío. Suministro no agregado.");
            }
            break;

        case 2:
            Console.WriteLine("Escribre el nombre del suministro a buscar:");
            string nombreBuscar = Console.ReadLine() ?? "";
            inventario.BuscarSuministro(nombreBuscar);
            break;
        case 3:
            Console.WriteLine("Escribre el nombre del suministro a eliminar:");
            string nombreEliminar = Console.ReadLine() ?? "";
            inventario.EliminarSuministro(nombreEliminar);
            break;
        case 4:
            Console.WriteLine("Inventario de Suministros:");
            inventario.MostrarSuministros();
            break;
        case 5:
            Console.WriteLine("Limpiando el inventario de suministros...");
            inventario.VaciarInventario();
            break;
        case 6:
            salir = true;
            Console.WriteLine("Saliendo del programa...");
            break;
        default:
            Console.WriteLine("Opción no válida. Por favor, elige una opción del 1 al 6.");
            break;
    }
} while (!salir);