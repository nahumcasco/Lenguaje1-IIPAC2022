decimal comision = 0;
decimal ventas = 0;

Console.WriteLine("Ingrese las ventas:");
ventas = Convert.ToDecimal(Console.ReadLine());

if (ventas >= 0 && ventas <= 1000)
{
    comision = ventas * 0 / 100;
    Console.WriteLine("La bonificación es: " + comision);
}
else if(ventas > 1000 && ventas <= 5000)
{
    comision = ventas * 3 / 100;
    Console.WriteLine("La bonificación es: " + comision);
}
else if(ventas > 5000 && ventas <= 20000)
{
    comision = ventas * 5 / 100;
    Console.WriteLine("La bonificación es: " + comision);
}
else
{
    comision = ventas * 8 / 100;
    Console.WriteLine("La bonificación es: " + comision);
}



