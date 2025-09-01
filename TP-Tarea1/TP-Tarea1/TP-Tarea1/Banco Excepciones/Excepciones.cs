//Programas de  excepciones
class SaldoInsuficienteException : Exception
{
    public SaldoInsuficienteException(string mensaje) : base(mensaje)
    {
    }
}

class CuentaNoEncontradaException : Exception
{
    public CuentaNoEncontradaException(string mensaje) : base(mensaje)
    {
    }
}

class DepositoInvalidoException : Exception
{
    public DepositoInvalidoException(string mensaje) : base(mensaje)
    {
    }
}
