//Programa pincipal del juego
try
{
    Console.WriteLine("Bienvenido al juego de guerreros!");
    //Obtener nombre del jugador
    string nombreJugardor = ObtenerNombre();
    //Seleccionar clase del guerrero
    Guerrero jugador = SeleccionarClase(nombreJugardor);
    Guerrero enemigo = GenerarEnemigo();

    Console.WriteLine($"Te enfrentas a un {enemigo.Nombre} con {enemigo.Vida} de vida y {enemigo.Ataque} de ataque!");
    //Bucle principal del juego
    while (jugador.Vida > 0 && enemigo.Vida > 0)
    {
        

        MostrarEstado(jugador, enemigo);
        int opcion = ObtenerOpcion();
        if (opcion == 1)
        {
            jugador.Atacar(enemigo);
        }
        else if (opcion == 2)
        {
            int proba = new Random().Next(0, 100);
            if (proba < 50)
            {
                Console.WriteLine("La fusión ha fallado. Pierdes vida.");
                jugador.RecibirDanio((int)(jugador.Vida * 0.1f));
                enemigo.Atacar(jugador);
                continue;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                jugador = jugador + enemigo;
                Console.WriteLine($"Has creado un nuevo guerrero: {jugador.Nombre}");
            }
        }
        else
        {
            throw new ArgumentException("Opcion invalida. Debe ser 1 o 2.");
        }

        //enemigo ataca si sigue vivo
        if (enemigo.Vida > 0)
        {
            enemigo.Atacar(jugador);
        }
        else if (jugador.Vida > 0)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Has derrotado a {enemigo.Nombre}!");
        }
        else {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("perdiste");
        }
          /*  Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(jugador.Vida>0 ? "Haz ganado!!" : "Perdiste..."); */
    }


}

catch (Exception ex)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Ha ocurrido un error inesperado: {ex.Message}");
}
finally
{
    Console.WriteLine("Gracias por jugar!");
}

static string ObtenerNombre()
{
    while (true)
    {
        try
        {
            Console.Write("Ingrese el nombre de su guerrero: ");
            string nombre = Console.ReadLine() ?? "".Trim();
            if (string.IsNullOrEmpty(nombre))
            {
                throw new ArgumentException("El nombre no puede estar vacío.");
            }

            //Tarea Evitar que la cadena sea un numero
            return nombre;
        }
        catch (Exception es)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Error al leer el nombre. Intente de nuevo. {es.Message}");
        }
    }
}

//Funcion para obetnere seleccion de menu
static int ObtenerOpcion()
{
    while (true)
    {
        try
        { 
            Console.WriteLine("Ingresa tu opcion:");
            int opcion = int.Parse(Console.ReadLine() ?? "");

            if (opcion != 1 && opcion != 2)
            {
                throw new ArgumentException("Opcion invalida. Debe ser 1 o 2.");
            }
            return opcion;
        }
        catch (Exception es)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Error al leer la opcion. Intente de nuevo. {es.Message}");
        }
    }
}

//Funcion para seleccion de la clase
 static Guerrero SeleccionarClase(string nombre)
{
    while (true)
    {
        try
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Selecciona la clase de tu guerrero:");
            Console.WriteLine("1. Caballero (Vida: 120, Ataque: 20)");
            Console.WriteLine("2. Mago (Vida: 80, Ataque: 25)");
            Console.WriteLine("3. Arquero (Vida: 90, Ataque: 15, 30% probabilidad de fallar)");
            Console.WriteLine("4. Guerrero Sombra (Vida: 110, Ataque: 22, 20% probabilidad de esquivar)");
            int opcion = int.Parse(Console.ReadLine() ?? "");
            return opcion switch
            {
                1 => new Caballero(nombre),
                2 => new Mago(nombre),
                3 => new Arquero(nombre),
                4 => new GuerreroSombra(nombre),
                _ => throw new ArgumentException("Clase invalida. Debe ser 1, 2 o 3 o 4."),
            };
        }
        catch (Exception es)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Error al seleccionar la clase. Intente de nuevo. {es.Message}");
        }
    }
}
//Funcion para crear un guerrero enemigo aleatorio
static Guerrero GenerarEnemigo()
{
    string[] nombres = { "Orco", "Goblin", "Troll", "Esqueleto", "Zombi" };
    string nombre = nombres[new Random().Next(nombres.Length)];

    int[] vidas = { 80, 100, 200, 150, 1000 };
    int vida = vidas[new Random().Next(vidas.Length)];

    int[] ataques = { 15, 27, 22, 30, 35 };
    int ataque = ataques[new Random().Next(ataques.Length)];

    return new Guerrero(nombre, vida, ataque);
}
//Funcion mostrar el esatdo
static void MostrarEstado(Guerrero jugador, Guerrero enemigo)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"Tu vida : {jugador.Vida} | Vida del enemigo: {enemigo.Vida}");
    Console.WriteLine("1 Atacar");
    Console.WriteLine("2 Fusionar");
}
