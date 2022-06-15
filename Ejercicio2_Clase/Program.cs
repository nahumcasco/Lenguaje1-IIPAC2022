decimal ventas = 0;
decimal porcentajeAumento = 5;
decimal salario = 0;
decimal nuevoSalario = 0;


Console.Write("Ingrese el salario del empleado: ");
salario = Convert.ToDecimal(Console.ReadLine());

Console.Write("Ingrese las ventas del empleado: ");
ventas = Convert.ToDecimal(Console.ReadLine());

if (ventas > 5000)
{
    nuevoSalario = (salario * porcentajeAumento / 100) + salario;
}
else
{
    nuevoSalario = salario;
}

Console.WriteLine("El nuevo salario es: " + nuevoSalario);
