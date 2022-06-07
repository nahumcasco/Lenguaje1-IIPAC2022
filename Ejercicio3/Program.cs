decimal num1, num2, resultado;
string linea;

Console.WriteLine("******Operaciones Básicas******");

Console.Write("Primer número: ");
linea = Console.ReadLine();
num1 = Convert.ToDecimal(linea);

Console.WriteLine("Segundo número: ");
linea = Console.ReadLine();
num2 = Convert.ToDecimal(linea);

Console.WriteLine();
resultado = num1 + num2;
Console.WriteLine("La suma es: {0}", resultado);

resultado = num1 - num2;
Console.WriteLine("La resta es: {0}", resultado);

resultado = num1 * num2;
Console.WriteLine("La multiplicación es: {0}", resultado);

resultado = num1 / num2;
Console.WriteLine("La división es: {0}", resultado);

Console.Write("");