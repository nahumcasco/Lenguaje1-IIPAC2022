//Variables

int edad;
string nombre;

Console.Write("Ingrese la edad de la persona: ");
edad = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingrese el nombre de la persona: ");
nombre = Console.ReadLine();

Console.Write(nombre + " tiene " + edad + " años.");
Console.ReadLine();