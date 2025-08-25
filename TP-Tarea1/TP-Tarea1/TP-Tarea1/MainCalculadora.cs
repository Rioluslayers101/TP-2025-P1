//Calcuadora Basica 
Console.WriteLine("Ingresa el primer numero a operar:");
double numero1 = double.Parse(Console.ReadLine()??"");
Console.WriteLine("Ingresa el segundo numero a operar:");
double numero2 = double.Parse(Console.ReadLine()??"");

Calculadora calcu1 = new Calculadora(numero1, numero2);
Calculadora calcu2 = new Calculadora(1, 2);
Calculadora sumacalcu = calcu1 + calcu2;

Console.WriteLine($"La suma de los numeros es: {sumacalcu.Numero1, sumacalcu.Numero2}");

//Selección de calculadora
Console.WriteLine("Selecciona la calculadora a utlizar:\n 1- Calculadora basica\n 2- Calcuadora cientifica");
int opCal = int.Parse(Console.ReadLine() ?? "");

switch (opCal)
{
    case 1:
        //Instanciar la calculadora base
        Calculadora calculadora = new Calculadora(numero1, numero2);
        //Operaciones
        Console.WriteLine("Selecciona la operacion a realizar:");
        Console.WriteLine("1. Sumar");
        Console.WriteLine("2. Restar");
        Console.WriteLine("3. Multiplicar");
        Console.WriteLine("4. Dividir");
       
        int opcion = int.Parse(Console.ReadLine() ?? "");
        switch (opcion)
        {
            case 1:
                calculadora.Sumar();
                calculadora.Sumar(4);
                break;
            case 2:
                calculadora.Restar();
                break;
            case 3:
                calculadora.Multiplicar();
                break;
            case 4:
                calculadora.Dividir();
                break;
            default:
                Console.WriteLine("Opcion no valida");
                break;
        }
        break;
    case 2:
        //Instancia la calculadora cientifica
        CalculadoraCientifica calcu = new CalculadoraCientifica(numero1, numero2);
        //Operaciones
        Console.WriteLine("Selecciona la operacion a realizar:");
        Console.WriteLine("1. Sumar");
        Console.WriteLine("2. Restar");
        Console.WriteLine("3. Multiplicar");
        Console.WriteLine("4. Dividir");
        Console.WriteLine("5. Factorial");
        Console.WriteLine("6. Raiz Cuadrada");
        Console.WriteLine("7. Logaritmo");
        calcu.MenCal();
        int opcionB = int.Parse(Console.ReadLine() ?? "");
        switch (opcionB)
        {
            case 1:
                calcu.Sumar();
                break;
            case 2:
                calcu.Restar();
                break;
            case 3:
                calcu.Multiplicar();
                break;
            case 4:
                calcu.Dividir();
                break;
            case 5:
                Console.WriteLine($"Resultado:{calcu.Factorial()}");
                break;
            case 6:
                Console.WriteLine($"Resultado:{calcu.RaizCuadrada()}");
                break;
            case 7:
                Console.WriteLine($"Resultado:{calcu.Logaritmo()}");
                break;
            default:
                Console.WriteLine("Opcion no valida");
                break;
        }
        break;
    default:
        Console.WriteLine("Opcion no valida");
        break;
}



CalculadoraCientifica calculadoraCientifica = new CalculadoraCientifica(numero1, numero2);
calculadoraCientifica.Factorial();