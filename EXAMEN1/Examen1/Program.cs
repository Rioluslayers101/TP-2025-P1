//Programa Principal

GestionProyectos gestionProyectos = new GestionProyectos();
try
{

    int numeroOperaciones = int.Parse(Console.ReadLine()??"");


        for (int i = 0; i < numeroOperaciones; i++)
        {
            string[] partes = (Console.ReadLine()??"").Split(' ');
            string comando = partes[0].ToUpper();

        switch (comando)
        {
         case "PROTECTO":
         {
         gestionProyectos.RegistrarProyecto(partes[1],partes[2]);
            break;
                }

            default:
         throw new ArgumentException("Comando no reconocido");
        }
        }
   
    

}





    public class Programador
{
    //Atributos
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string TecnologiaPrincipal { get; set; }
    public int ExitosIndividuales { get; set; }
    public int ExitosEnEquipo { get; set; }
    public string Equipo { get; set; }


    public enum NivelResultadoEquipo
        {
        EXITOSO,
        FALLIDO,
        INCOMPLETO
    }
    //Constructor
    
    public Programador(string nombre, int edad, string tecnologiaPrincipal, string equipo)
    {
        Nombre = nombre;
        Edad = edad;
        TecnologiaPrincipal = tecnologiaPrincipal;
        ExitosIndividuales = 0;
        ExitosEnEquipo = 0;
        Equipo = equipo;
    }

    //Metodos
    public void RegistrarResultadoIndividual(int nivel, string nombreproyecto)
    {
        if(nivel<1 || nivel >3)
        {
            throw new ArgumentOutOfRangeException("El nivel debe estar entre 1 y 3");
        }

        if (nivel == 1)
        {
            ExitosIndividuales++;
        }
        Console.WriteLine($"{Nombre} {nombreproyecto}");
    }
    //Sobrecarga con comentario
    public void RegistrarResultadoIndividual(int nivel, string nombreproyecto, string comentario)
    {
        if (!string.IsNullOrEmpty(comentario))
        {
            Console.WriteLine($"{Nombre} {nombreproyecto} {comentario}");
            RegistrarResultadoIndividual(nivel, nombreproyecto);
        }
        else
        {
            throw new ArgumentException("El comentario no puede estar vacio");
        }
    }
    //Resultado en equipo
    public void RegistrarResultadoEnEquipo(NivelResultadoEquipo nivel, string nombreproyecto)
    {
        if (nivel == NivelResultadoEquipo.EXITOSO )
        { 
            ExitosEnEquipo++;
        }
        Console.WriteLine($"{Nombre} {nombreproyecto}");
    }
    //Sobrecarga con comentario
    public void RegistrarResultadoEnEquipo(NivelResultadoEquipo nivel, string nombreproyecto, string comentario)
    {
        if (!string.IsNullOrEmpty(comentario))
        {
            Console.WriteLine($"{Nombre} {nombreproyecto} {comentario}");
            RegistrarResultadoEnEquipo(nivel, nombreproyecto);
        }
        else
        {
            throw new ArgumentException("El comentario no puede estar vacio");
        }
    }

}

//Clases Hijas
public class ProgramadorIndividual : Programador
{
    //Constructor
    public ProgramadorIndividual(string nombre, int edad, string tecnologiaPrincipal, string equipo) : base(nombre, edad, tecnologiaPrincipal, "")

    {
    }
}   
public class ProgramadorEquipo : Programador
{
    //Constructor
    public ProgramadorEquipo(string nombre, int edad, string tecnologiaPrincipal, string equipo) : base(nombre, edad, tecnologiaPrincipal, equipo)
    {
        if (string.IsNullOrEmpty(equipo))
        {
            throw new ArgumentException("El programador de equipo debe pertenecer a un equipo");
        }
    }
}
//Registro de proyectos
public class Proyecto
{
    public string Nombre { get; set; }
    public string Tecnologia { get; set; }
    //Constructor
    public Proyecto(string nombre, string tecnologia)
    {
        if (string.IsNullOrWhiteSpace(nombre))
        {
            throw new ArgumentException("El nombre del proyecto no puede estar vacío");
        }

        if (string.IsNullOrWhiteSpace(tecnologia))
        {
            throw new ArgumentException("La tecnología del proyecto no puede estar vacía");
        }

        Nombre = nombre;
        Tecnologia = tecnologia;
    }
}
//Interfaz de estrategia de evaluacion
interface IEstrategiaEvaluacion
{
    int ObtenerValor(Programador programador);
}

//Estrategia por Exitos Individuales
public class EvaluacionPorExitosIndividuales : IEstrategiaEvaluacion
{
    public int ObtenerValor(Programador programador)
    {
        return programador.ExitosIndividuales;
    }
}
//Estrategia por Exitos en Equipo
public class EvaluacionPorExitosEnEquipo : IEstrategiaEvaluacion
{
    public int ObtenerValor(Programador programador)
    {
        return programador.ExitosEnEquipo;
    }
}

//Clase Gestion de Proyectos
public class GestionProyectos
{
    private List<Proyecto> proyectos = new List<Proyecto>();
    private List<Programador> programadores = new List<Programador>();
    private IEstrategiaEvaluacion estrategiaEvaluacion = new EvaluacionPorExitosIndividuales();
    public void RegistrarProyecto(Proyecto proyecto)
    {
        if (proyecto == null)
        {
            throw new ArgumentNullException(nameof(proyecto), "El proyecto no puede ser nulo");
        }
        proyectos.Add(proyecto);
    }
    public void AgregarProgramador(Programador programador)
    {
        if (programador == null)
        {
            throw new ArgumentNullException(nameof(programador), "El programador no puede ser nulo");
        }
        programadores.Add(programador);
    }

    //Registrar Resultado Individual
    public void RegistrarResultadoIndividual(Programador programador, int nivel, string nombreproyecto, string comentario = "")
    {
        if (!programadores.Contains(programador))
        {
            throw new ArgumentException("El programador no está registrado en el sistema");
        }
        if (string.IsNullOrEmpty(comentario))
        {
            programador.RegistrarResultadoIndividual(nivel, nombreproyecto);
        }
        else
        {
            programador.RegistrarResultadoIndividual(nivel, nombreproyecto, comentario);
        }
    }
    //Registrar Resultado en Equipo
    public void RegistrarResultadoEnEquipo(Programador programador, Programador.NivelResultadoEquipo nivel, string nombreproyecto, string comentario = "")
    {
        if (!programadores.Contains(programador))
        {
            throw new ArgumentException("El programador no está registrado en el sistema");
        }
        if (string.IsNullOrEmpty(comentario))
        {
            programador.RegistrarResultadoEnEquipo(nivel, nombreproyecto);
        }
        else
        {
            programador.RegistrarResultadoEnEquipo(nivel, nombreproyecto, comentario);
        }
    }
    //Cambiar Estrategia de Evaluacion
    public void CambiarEstrategiaEvaluacion(string criterio)
    {
        if(criterio == "ExitosIndividuales")
        {
            estrategiaEvaluacion = new EvaluacionPorExitosIndividuales();
        }
        else if (criterio == "ExitosEnEquipo")
        {
            estrategiaEvaluacion = new EvaluacionPorExitosEnEquipo();
        }
        else
        {
            throw new ArgumentException("Criterio de evaluación no válido");
        }
    }

    //Obtener Mejor Programador
    public void MostrarMejorProgramador(string tecnologia)
    {
        List<Programador> programadoresFiltrados = programadores.Where(p => p.TecnologiaPrincipal == tecnologia).ToList();
        if (programadoresFiltrados.Count == 0)
        {
            Console.WriteLine("No hay programadores con la tecnología especificada");
            return;
        }
        Programador mejorProgramador = programadoresFiltrados.OrderByDescending(p => estrategiaEvaluacion.ObtenerValor(p)).First();
        Console.WriteLine($"El mejor programador en {tecnologia} es {mejorProgramador.Nombre} con {estrategiaEvaluacion.ObtenerValor(mejorProgramador)} éxitos.");
    }
}