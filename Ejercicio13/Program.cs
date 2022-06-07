
string clave = "1234";
string claveIngresada;


do
{
    Console.WriteLine("Ingrese su Contraseña");
    claveIngresada = Console.ReadLine();

    if (claveIngresada != clave)
    {
        Console.WriteLine("La Contraseña es incorrecta");
    }
}
while (clave != claveIngresada);

Console.WriteLine("Bienvenido al sistema");