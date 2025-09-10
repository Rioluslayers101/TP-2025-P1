//Porgama Principal

IEjemplo elgo = new IEjemplo.Ejemplo();
elgo.HacerAlgo();
elgo.HacerAlgoMas();

Ejemplo otroElgo = new IEjemplo.Ejemplo();
otroElgo.HacerAlgo();
otroElgo.HacerAlgoMas();
//Interfaz
public interface IEjemplo
{
    //Metodo
    void HacerAlgo();
    //Metodo 
    void HacerAlgoMas();
  
    //Clase que implementa la interfaz

    public class Ejemplo : IEjemplo
    {
        //Implementacion del metodo
        public void HacerAlgo()
        {
            Console.WriteLine("Haciendo algo...");
        }
        public void HacerAlgoMas()
        {
            Console.WriteLine("Haciendo algo mas...");
        }

    }
}