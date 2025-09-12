//Programa Pincipal
//Implementacion historial de pagos con listas
List<IPago> ListaPagos = new List<IPago>();

Console.WriteLine("Ingresa el monto a pagar");
string  montoTexto = Console.ReadLine()??"";

if(double.TryParse(montoTexto, out double monto))
{
    Console.WriteLine("El pago es con tarjeta? s/n");
    string opcion = Console.ReadLine()??"".ToLower();
    if(opcion == "s")
    {
        Console.WriteLine("Ingresa el numero de tarjeta");
        string numeroTarjeta = Console.ReadLine()??"";
        //Crear objeto de pago con tarjeta

        IPago pagoTarjeta = new PagoTarjeta(monto, numeroTarjeta);
        ListaPagos.Add(pagoTarjeta);
    }
    else
    {
        Console.WriteLine("Pago en efectivo");
        IPago pagoEfectivo = new PagoEfectivo(monto);
        ListaPagos.Add(pagoEfectivo);
    }

    foreach (IPago p in ListaPagos)
    {
        PagoTarjeta pagoTarjeta = p as PagoTarjeta;

        if (pagoTarjeta != null)
        {
            Console.WriteLine("Pago con tarjeta detectado");
            pagoTarjeta.ProcesarPago();
        }

        //Todo procesasr pagos con efectivo
    }
}

//TODO Hacer el pago iterativo hasta que no haya pagos






//Interface Ipago
interface IPago
{
    //Metodo pagar
    public void ProcesarPago();
}

//Clase PagoEfectivo que implementa la interfaz IPago
public class PagoEfectivo : IPago
{
    //Atributos
    public double Monto { get; set; }
    //Constructor

    public PagoEfectivo(double monto)
    {
        Monto = monto;
    }
    //Implementacion del metodo pagar
    public void ProcesarPago()
    {
        Console.WriteLine($"Procesando pago en efectivo de {Monto}");
    }
}
//Clase PagoTarjeta que implementa la interfaz IPago

public class PagoTarjeta : IPago
{
    //Atributos
    public double Monto { get; set; }
    public string NumeroTarjeta { get; set; }

    //Constructor

    public PagoTarjeta(double monto, string numeroTarjeta)
    {
        Monto = monto;
        NumeroTarjeta = numeroTarjeta;
    }

    //Implementacion del metodo pagar
    public void ProcesarPago()
    {
        if (NumeroTarjeta.Length ==16)
        {
            Console.WriteLine($"Procesando pago con tarjeta {NumeroTarjeta} de {Monto}");
        }
        else
        {
            Console.WriteLine("Tarjeta invalida");
        }
    }
}
