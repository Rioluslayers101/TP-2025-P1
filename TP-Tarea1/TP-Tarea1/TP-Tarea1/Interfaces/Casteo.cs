//Programa principal d casteos

//Convertir un tipo de dato en otro
int numero = 10;
double numDouble = numero; //Casteo implcito

Console.WriteLine(numDouble);

//Conversion explicita
double numDouble2 = 9.78;
int numInt = (int)numDouble2; //Casteo explicito
Console.WriteLine(numInt);

//Con Métodos
string texto = "123";
int numInt2 = Convert.ToInt32(texto);
Console.WriteLine(numInt2);

//Parse
string texto2 = "456.56";
double numDouble3 = double.Parse(texto2);
Console.WriteLine(numDouble3);
//TryParse
string texto3 = "99.12";
bool exito = double.TryParse(texto3, out double numDouble4);
Console.WriteLine(exito);
Console.WriteLine(numDouble4);
if (exito)
{
    Console.WriteLine(numDouble4);
}
else
{
    Console.WriteLine("Conversion fallida");
}

//Casteo entr objetos y clases

Animal miAnimal = new Perro();
miAnimal.HacerSonido();

//Down casting Padre -> Hijo
Perro miPerro = (Perro)miAnimal;
miPerro.SonidoPerro();

//Up casting Hijo -> Padre



//Conversion por tipos de referencia
object obj = new Perro();
string cadena = obj as string;
Console.WriteLine(cadena);


public class Animal
{
    //Metodos

    public void HacerSonido()
    {
        Console.WriteLine("Sonido generico");
    }
}

public class Perro : Animal
{
    //Sobreescritura del metodo
    public void SonidoPerro()
    {
        Console.WriteLine("Gua Gua");
    }
}