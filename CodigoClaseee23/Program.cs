

using CodigoClaseee23;

void Ejercicio01()
{

    List<int> numeros = new List<int>();
	for (int i = 0; i < 10; i++)
	{
		numeros.Add(i);
	}

	var pares = numeros.Where(x => x % 2 == 0).ToList();

	foreach (var item in pares)
	{
		Console.WriteLine(item);
	}

}

void Ejercicio03()
{
    List<Persona> personas = new List<Persona>();
	personas.Add(new Persona { Edad = 18, Nombre = "Hugo" });
    personas.Add(new Persona { Edad = 20, Nombre = "Reene" });
    personas.Add(new Persona { Edad = 18, Nombre = "Bruno" });
    personas.Add(new Persona { Edad = 25, Nombre = "Marlon" });


    var pares = personas.Where(x => x.Edad>18).ToList();

    foreach (var item in pares)
    {
        Console.WriteLine(item.Nombre);
    }
}



//Ejercicio01();
Ejercicio03();
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



