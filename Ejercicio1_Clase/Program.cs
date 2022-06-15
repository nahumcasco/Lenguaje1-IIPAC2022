decimal salario = 0;
decimal porcentajeComision = 5;
decimal ventas = 0;
decimal comision = 0;

Console.WriteLine("Ingrese las ventas del empleado:");
ventas = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Ingrese el salario del empleado:");
salario = Convert.ToDecimal(Console.ReadLine());

if (salario <= 20000)
{
    comision = ventas * porcentajeComision / 100;
}

Console.WriteLine($"La comisión a recibir es: {comision}");
Console.ReadKey();
