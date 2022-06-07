int n, positivos, negativos, pares, impares, valor;
positivos = 0;
negativos = 0;
pares = 0;
impares = 0;

Console.WriteLine("***** Ciclo FOR ******");
Console.WriteLine("-----------------------\n");

Console.Write("Ingrese la cantidad de valores a evaluar: ");
n = Convert.ToInt32(Console.ReadLine());
Console.Write("\n");

for (int i = 1; i <= n ; i++)
{
    Console.Write("Ingrese el número {0}: " , i );
    valor = Convert.ToInt32(Console.ReadLine());

    if (valor > 0)
    {
        positivos++;
    }
    else
    {
        if (valor < 0)
        {
            negativos++;
        }
    }
    if (valor % 2 == 0)
    {
        pares++;
    }
    else
    {
        if (valor % 2 != 0)
        {
            impares++;
        }
    }
}

Console.Write("\n");
Console.WriteLine("La cantidad de números pares es: " + pares);
Console.WriteLine("La cantidad de números impares es: " + impares);
Console.WriteLine("La cantidad de números positivos es: " + positivos);
Console.WriteLine("La cantidad de números negativos es: " + negativos);
Console.ReadKey();