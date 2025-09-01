//Programa principal dispositivos
//Instanciamos los objetos
using System;

Ventilador ventilador1 = new Ventilador("Ventilador", 75, 3);
Lampara lampara1 = new Lampara("Lampara", 40, 80);
//Encendemos los dispositivos
ventilador1.Encender();
lampara1.Encender();
//Ajustamos el consumo
ventilador1.AjustarConsumo(90);
lampara1.AjustarConsumo();
//Mostramos la informacion de los dispositivos
Console.ForegroundColor = ConsoleColor.Red;
ventilador1.MostrarInfo();
lampara1.MostrarInfo();
//Comparamos la informacion de los dispositivos
if (ventilador1.Consumo > lampara1.Consumo)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"{ventilador1.Nombre} consume mas que {lampara1.Nombre}");
}
else if (ventilador1.Consumo < lampara1.Consumo)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"{lampara1.Nombre} consume mas que {ventilador1.Nombre}");
}
else
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"{ventilador1.Nombre} y {lampara1.Nombre} consumen lo mismo");
}