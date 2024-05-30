//Mi Primer Comentario
//Quinto comentario

using CodigoClaseee23;
using System.Security.Cryptography.X509Certificates;

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
    personas.Add(new Persona { Edad = 25, Nombre = "Delvenith" });



    var pares = personas.Where(x => x.Edad>18).ToList();

    foreach (var item in pares)
    {
        Console.WriteLine(item.Nombre);
    }
}


void Ejercicio06()
{
    List<Persona> personas = new List<Persona>();
    personas.Add(new Persona { Edad = 18, Nombre = "Hugo" });
    personas.Add(new Persona { Edad = 20, Nombre = "Reene" });
    personas.Add(new Persona { Edad = 18, Nombre = "Bruno" });
    personas.Add(new Persona { Edad = 25, Nombre = "Marlon" });

    var personsfiltradas = personas.Where(x => x.Nombre.Length > 5).ToList();

    foreach (var item in personsfiltradas)
    {
        Console.WriteLine(item.Nombre);
    }

}

void Ejercicio07()
{


    List<int> numeros = new List<int>();
    for (int i = 0; i < 10; i++)
    {
        numeros.Add(i);
    }

    var maximo = numeros.Max();
    var maximo2 = numeros.OrderDescending().FirstOrDefault();

    Console.WriteLine(maximo);
    Console.WriteLine(maximo2);
}



void Ejercicio08()
{
    List<Persona> personas = new List<Persona>();
    personas.Add(new Persona { Edad = 18, Nombre = "Hugo" });
    personas.Add(new Persona { Edad = 20, Nombre = "Reene" });
    personas.Add(new Persona { Edad = 18, Nombre = "Bruno" });
    personas.Add(new Persona { Edad = 25, Nombre = "Marlon" });
    personas.Add(new Persona { Edad = 25, Nombre = "Dalvenith" });


    //take: toma la cantidad de registros que tu le pides
    var personasOrdenadas = personas.OrderBy(x => x.Nombre).Take(2).ToList();

    foreach (var item in personasOrdenadas)
    {
        Console.WriteLine(item.Nombre);
    }

}

void Ejercicio09()
{
    List<Estudiante> estudiantes = new List<Estudiante>();
    estudiantes.Add(new Estudiante { Nombre = "Hugo", Nota = 12 });
    estudiantes.Add(new Estudiante { Nombre = "Reene", Nota =  20});
    estudiantes.Add(new Estudiante { Nombre = "Marlon", Nota = 18 });
    estudiantes.Add(new Estudiante { Nombre = "Roberto", Nota = 15 });
    estudiantes.Add(new Estudiante { Nombre = "Juan", Nota = 16 });
    estudiantes.Add(new Estudiante { Nombre = "Darwin", Nota = 18 });
    var estrellla = estudiantes.OrderByDescending(x => x.Nota).FirstOrDefault();
    Console.WriteLine(estrellla.Nombre);
}

//Cuántas personas hay en cada país y el promedio de edad por pais
void Ejercicio10()
{
    List<Persona> personas = new List<Persona>();
    personas.Add(new Persona { Nombre = "Juan", Pais = "Costa Rica",Edad=20 });
    personas.Add(new Persona { Nombre = "Ana", Pais = "Perú",Edad=30 });
    personas.Add(new Persona { Nombre = "Carlos", Pais = "Costa Rica",Edad=40 });
    personas.Add(new Persona { Nombre = "Maria", Pais = "Perú",Edad=50 });
    personas.Add(new Persona { Nombre = "Luis", Pais = "Argentina",Edad = 20 });

    //Agrupar por pais
    //pais= key!!!
    var paises = personas.GroupBy(x => x.Pais).
                          Select(x => new
                                {
                                NombrePais = x.Key,
                                Cantidad = x.Count()
                                }
                          ).ToList();

    foreach (var item in paises)
    {
        Console.WriteLine(item.NombrePais);
        Console.WriteLine(item.Cantidad);
    }
    /*
     Perú = 2
     Costa Rica= 2
     Argentina= 1
     */

}



//Ejercicio01();
//Ejercicio03();
//Ejercicio06();
//Ejercicio07();
//Ejercicio08();
//Ejercicio09();
Ejercicio10();

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



