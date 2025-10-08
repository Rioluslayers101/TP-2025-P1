public class Robot
{
    //Atributos
    public float Peso { get; set; }
    public string Modelo { get; set; }
    public bool Estado { get; set; }
    public int EnergiaDisponible { get; set; }
    //Constructor
    public Robot()
    {
        Peso = 5.0f;
        Modelo = "Robot Generico";
        Estado = false; //Apagado por defecto
        EnergiaDisponible = 100; //Energía inicial
    }
    public Robot(string modelo, float peso, int energiadisponible)
    {
        Peso = peso;
        Modelo = modelo;
        EnergiaDisponible = energiadisponible;
        Estado = false;
    }
    //Métodos

    public virtual void Encender()
    {
        if (!Estado)
        {
            Estado = true;
            Console.WriteLine("El robot está encendido.");
        }
        else
        {            
            Console.WriteLine("El robot ya está encendido.");
        }
    }
    public virtual void Apagar()
    {
        if (Estado)
        {
            Estado = false;
            Console.WriteLine("El robot está apagado.");
        }
        else
        {
            Console.WriteLine("El robot ya está apagado.");
        }
    }
    public virtual int VerificarEnergia()
    {
        Console.WriteLine($"Energía disponible: {EnergiaDisponible}%");
        return EnergiaDisponible;

    }
    public virtual void RecargarEnergia(int cantidad)
    {
        EnergiaDisponible += cantidad;
        if (EnergiaDisponible > 100)
            EnergiaDisponible = 100; //Límite máximo de energía
        Console.WriteLine($"Energía recargada. Energía disponible: {EnergiaDisponible}%");
    }
    public void MostrarEstado()
    {
        string estadoStr = Estado ? "Encendido" : "Apagado";
        Console.WriteLine($" Estado: {estadoStr}");
    }
    public virtual void MostrarInformacion()
    {
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Peso: {Peso} kg");
    }
}

//RobotMovil.cs
public class RobotMovil : Robot
{
    //Atributos
    public float Velocidad { get; set; }
    public string Direccion { get; set; }
    public int MotorIzquierdo { get; set; }
    public int MotorDerecho { get; set; }
    public bool SensorUltrasonico { get; set; }
    //Constructor
    public RobotMovil(string modelo, float peso, int energiadisponible) : base(modelo, peso, energiadisponible)
    {
        Velocidad = 0.0f;
        Direccion = "Detenido";
        SensorUltrasonico = true;
        EnergiaDisponible = energiadisponible;
    }
    //Metodos sobrescritos
    public override void Encender()
    {
        base.Encender();
        SensorUltrasonico = true; //Activar sensor al encender
        Console.WriteLine("El robot móvil está listo para moverse.");
    }
    public override void Apagar()
    {
        base.Apagar();
        SensorUltrasonico = false; //Desactivar sensor al apagar
        Console.WriteLine("El robot móvil está apagado y sus sensores desactivados");
    }
    public override int VerificarEnergia()
    {
        int energia = base.VerificarEnergia();
        Console.WriteLine("Verificando energía del robot móvil..." + energia);
        return energia;
    }
    public override void RecargarEnergia(int cantidad)
    {
        Console.WriteLine("Recargando energía del robot móvil..." + EnergiaDisponible);
        base.RecargarEnergia(cantidad);
    }
    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Velocidad: {Velocidad} m/s");
        Console.WriteLine($"Dirección: {Direccion}");
    }
    //Métodos específicos
    public int ConsumirEnergia(int cantidad)
    {
        EnergiaDisponible -= cantidad;
        if (EnergiaDisponible < 0)
            EnergiaDisponible = 0; //Límite mínimo de energía
        return EnergiaDisponible;
    }

    public void Mover(string direccion, float velocidad)
    {
        if (Estado && EnergiaDisponible > 0)
        {
            Direccion = direccion;
            Velocidad = velocidad;
            ConsumirEnergia(10); //Consumo de energía al moverse
            Console.WriteLine($"El robot móvil se está moviendo hacia {Direccion} a {Velocidad} m/s.");
        }
        else if (!Estado)
        {
            Console.WriteLine("El robot móvil está apagado. No puede moverse.");
        }
        else
        {
            Console.WriteLine("Energía insuficiente para moverse. Por favor, recargue.");
        }
    }
    public void Detener()
    {
        if (Estado)
        {
            Direccion = "Detenido";
            Velocidad = 0.0f;
            Console.WriteLine("El robot móvil se ha detenido.");
        }
        else
        {
            Console.WriteLine("El robot móvil está apagado. No puede detenerse.");
        }
    }
    public void GiroPorDiferencial(int motorIzquierdo, int motorDerecho)
    {
            if (Direccion == "Derecha")
        {
            MotorDerecho = 0;
            MotorIzquierdo = 50;
            ConsumirEnergia(5); //Consumo de energía al girar
        }
        else if (Direccion == "Izquierda")
        {
            MotorDerecho = 40;
            MotorIzquierdo = 0;
            ConsumirEnergia(5); //Consumo de energía al girar
        }
        Console.WriteLine($"El robot móvil está girando a la {Direccion} con motores: Izquierdo={MotorIzquierdo}, Derecho={MotorDerecho}");
    }
    public void GiroPorContrarrotacion(int motorIzquierdo, int motorDerecho)
    {

            if (Direccion == "Derecha")
        {
            MotorDerecho = 50;
            MotorIzquierdo = 50;
            ConsumirEnergia(5);
        }
        else if (Direccion == "Izquierda")
        {
            MotorDerecho = 50;
            MotorIzquierdo = 50;
            ConsumirEnergia(5);
        }
        Console.WriteLine($"El robot móvil está girando a la {Direccion} con motores: Izquierdo={MotorIzquierdo}, Derecho={MotorDerecho}");
    }

    public void ObtenerDistanciaSensorUltrasonico()
    {
            ConsumirEnergia(10);
            Random rand = new Random();
            int distancia = rand.Next(1, 100); //Simula una distancia entre 1 y 100 cm
            Console.WriteLine($"Distancia medida por el sensor ultrasónico: {distancia} cm");
    }

    public void AumnetarVelocidad(int incremento)
    {
            Velocidad += incremento;
        if (Velocidad > 100.0f) //Límite máximo de velocidad
            Velocidad = 100.0f;
        ConsumirEnergia(5); //Consumo de energía al aumentar velocidad
        Console.WriteLine($"Velocidad aumentada. Nueva velocidad: {Velocidad} m/s");
    }
    public void DisminuirVelocidad(int decremento)
    { 
            Velocidad -= decremento;
        if (Velocidad < 0.0f) //Límite mínimo de velocidad
            Velocidad = 0.0f;
        ConsumirEnergia(5); //Consumo de energía al disminuir velocidad
        Console.WriteLine($"Velocidad disminuida. Nueva velocidad: {Velocidad} m/s");   
    }
}


