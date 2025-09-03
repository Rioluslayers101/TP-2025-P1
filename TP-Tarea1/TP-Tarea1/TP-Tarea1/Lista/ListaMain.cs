//Programa lista de personas
List<PersonaL> listaPersonas = new List<PersonaL>();
listaPersonas.Add(new PersonaL("Juan", 25));
listaPersonas.Add(new PersonaL("Ana", 30));
listaPersonas.Add(new PersonaL("Luis", 28));
listaPersonas.Add(new PersonaL("Maria", 15));
listaPersonas.Add(new PersonaL("Carlos", 10));

//Mostrar informacion de las personas
foreach (PersonaL persona in listaPersonas)
{
    if (persona.Edad > 18)
    {
        persona.MostrarInformacion();
    }
}


