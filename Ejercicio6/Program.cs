
Console.WriteLine("** Aplicación de Clima **\n");

int temperatura;
string clima;

Console.WriteLine("Ingrese la temperatura: ");
temperatura = Convert.ToInt32(Console.ReadLine());

if (temperatura < 10)
{
    clima = "Frío";
}
else if (temperatura >= 10 && temperatura <=20)
{
    clima = "Nublado";
}
else if (temperatura >= 21 && temperatura <=30)
{
    clima = "Calor";
}
else
{
    clima = "Tropical";
}

Console.WriteLine("El clima actual es: {0}", clima);
