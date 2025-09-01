//Programa principal del Banco
Banco banco = new Banco();

try 
{
    Console.WriteLine("Ingrese el numero de cuenta:");
    string numeroCuenta = Console.ReadLine()??"";

    CuentaBancaria cuenta = banco.BuscarCuenta(numeroCuenta);

    //Depositar

    Console.WriteLine("Ingrese la cantidad:");
    double num = double.Parse(Console.ReadLine()??"");
    cuenta.Depositar((decimal)num);


    //Transferencia

    Console.WriteLine("Ingrese el numero de dcuenta:");
    string numeCuentaDestino = Console.ReadLine() ?? "";

    CuentaBancaria cuentaDestino = banco.BuscarCuenta(numeCuentaDestino);
    Console.WriteLine("Ingrese la cantidad a transferir:");

    double numTrans = double.Parse(Console.ReadLine() ?? "");

    cuenta.Transferir(cuentaDestino, (decimal)numTrans);

    //Retirar
    
    Console.WriteLine("Ingrese la cantidad a retirar:");
    double numRet = double.Parse(Console.ReadLine() ?? "");
    cuenta.Retirar((decimal)numRet);
}

catch (SaldoInsuficienteException e)
{
    Console.WriteLine(e.Message);
}
catch (CuentaNoEncontradaException e)
{
    Console.WriteLine(e.Message);
}
catch (DepositoInvalidoException e)
{
    Console.WriteLine(e.Message);
}
