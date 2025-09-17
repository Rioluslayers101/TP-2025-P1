//Programa principal


List<IDispositivoInteligente> dispositivos = new List<IDispositivoInteligente>
{
   new Lamp(),
   new Ventilador(),
   new Altavoz()


};
//Encender todos los dispositivos
foreach (var dispositivo in dispositivos)
{
    dispositivo.Encender();
    dispositivo.MostrarEstado();
}

//Interactuar con cada dispositivo
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Ajutar configuraciones...");
((Lamp)dispositivos[0]).AjustarBrillo(80);
((Ventilador)dispositivos[1]).AjustarVelocidad(30);
((Altavoz)dispositivos[2]).ReproducirMusica("40 y 20");

//Mostrar estado despues de ajustes
Console.ForegroundColor = ConsoleColor.Yellow;
foreach (var dispositivo in dispositivos)
{
    dispositivo.MostrarEstado();
}

//Apagar todos los dispositivos
Console.ForegroundColor = ConsoleColor.Red;
foreach (var dispositivo in dispositivos)
{
    dispositivo.Apagar();
    dispositivo.MostrarEstado();
}
Console.ForegroundColor = ConsoleColor.Blue;
//Encender todos los dispositivos
foreach (var dispositivo in dispositivos)
{
    dispositivo.Encender();
    dispositivo.MostrarEstado();
}

Console.ForegroundColor = ConsoleColor.White;
//Interfaz
interface IDispositivoInteligente
{
    void Encender();
    void Apagar();
    void MostrarEstado();
}
//Class de la lampara
public class Lamp : IDispositivoInteligente
{
    //Atrivutis
    private bool encendido = false;
    private int brillo = 50;
    //Metodos
    public void Encender()
    {
        encendido = true;
        Console.WriteLine("La lámpara está encendida.");
        brillo = 50; // Brillo inicial al encender
    }

    public void Apagar()
    {
        encendido = false;
        Console.WriteLine("La lámpara está apagada.");
       //Brillo ajustado a 0 al apagar
        brillo = 0;
    }
    public void MostrarEstado()
    {
        Console.WriteLine($"Lampara - Estado {(encendido ? "Encendido" : "Apagada")}, Brillo: {brillo}");
    }
    public void AjustarBrillo(int nuevoBrillo)
    {
        if (nuevoBrillo < 0 || nuevoBrillo > 100)
        {
            Console.WriteLine("El brillo debe estar entre 0 y 100.");
            return;
        }
        brillo = nuevoBrillo;
        Console.WriteLine($"Brillo ajustado a {brillo}%.");
    }
}
    //Class para el ventilador
    public class Ventilador : IDispositivoInteligente
    {
        //Atributos
        private bool encendido = false;
        private int velocidad = 1; // Velocidad de 1 a 5
        //Metodos
        public void Encender()
        {
            encendido = true;
            Console.WriteLine("El ventilador está encendido.");
            velocidad = 1; // Velocidad inicial al encender
    }
        public void Apagar()
        {
            encendido = false;
            Console.WriteLine("El ventilador está apagado.");
            velocidad = 0; // Velocidad a 0 al apagar
        }
        public void MostrarEstado()
        {
            Console.WriteLine($"Ventilador - Estado {(encendido ? "Encendido" : "Apagado")}, Velocidad: {velocidad}");
        }
        public void AjustarVelocidad(int nivel)
        {
           velocidad = Math.Clamp(nivel,0,100); // Asegura que la velocidad esté entre 1 y 5
            Console.WriteLine($"Velocidad ajustada a {velocidad}.");
        }
    }
    //Public Altavoz
    public class Altavoz : IDispositivoInteligente
    {
        //Atributos
        private bool encendido = false;
        private string cancionActual = "Ninguna";
        //Metodos
        public void Encender()
        {
            encendido = true;
            Console.WriteLine("El altavoz está encendido.");
        }
        public void Apagar()
        {
            encendido = false;
            Console.WriteLine("El altavoz está apagado.");
            cancionActual = "Ninguna"; // Canción a "Ninguna" al apagar
    }
        public void MostrarEstado()
        {
            Console.WriteLine($"Altavoz - Estado {(encendido ? "Encendido" : "Apagado")}, Reproduciendo: {cancionActual}");
        }
        public void ReproducirMusica(string cancion)
        {
   
            cancionActual = cancion;
            Console.WriteLine($"{(encendido ? $"Reproduciendo : {cancionActual}": $"Reprodocuendo Nada")}");
        }
    }
