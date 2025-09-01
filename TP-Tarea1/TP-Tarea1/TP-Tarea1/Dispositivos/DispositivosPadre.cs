public class DispositivosPadre
{
    //Atributos
    private string nombre;
    private bool encendido;
    private int consumo;
    //Constructor
    public DispositivosPadre(string nombre, int consumo)
    {
        this.nombre = nombre;
        this.consumo = consumo;
        this.encendido = false; // Inicializa el dispositivo como apagado
    }
    //Propiedades publicas
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }
    public bool Encendido
    {
        get { return encendido; }
        private set { encendido = value; }
    }
    public int Consumo
    {
        get { return consumo; }
        set { consumo = value; }
    }
    //Si el dispostivo esta apagado consumo devuelve 0
    private int ConsumoActual
    {
        get { return encendido ? consumo : 0; }
    }
    //Metodos
    public void Encender()
    {
        Encendido = true;
        Console.WriteLine($"{Nombre} esta encendido. Consumo actual: {ConsumoActual}W");
    }
    public void Apagar()
    {
        Encendido = false;
        Console.WriteLine($"{Nombre} esta apagado. Consumo actual: {ConsumoActual}W");
    }
    //Sobre carga de metodos
    public void AjustarConsumo(int nuevoConsumo)
    {
        Consumo = nuevoConsumo;
        Console.WriteLine($"{Nombre} consumo ajustado a: {Consumo}W");
    }
    public void AjustarConsumo()
    {
        Consumo = 100;
        Console.WriteLine($"{Nombre} consumo ajustado a valor por defecto: {Consumo}W");
    }
    //Mostrar info
    public virtual void MostrarInfo()
    {
        Console.WriteLine($"Dispositivo: {Nombre}, Encendido: {Encendido}, Consumo: {Consumo}W");
    }
    //Sobrecarga de operadores
    public static bool operator >(DispositivosPadre d1, DispositivosPadre d2)
    {
        return d1.Consumo > d2.Consumo;
    }
    public static bool operator <(DispositivosPadre d1, DispositivosPadre d2)
    {
        return d1.Consumo < d2.Consumo;
    }
    public static bool operator ==(DispositivosPadre d1, DispositivosPadre d2)
    {
        return d1.Consumo == d2.Consumo;
    }
    public static bool operator !=(DispositivosPadre d1, DispositivosPadre d2)
    {
        return d1.Consumo != d2.Consumo;
    }

}