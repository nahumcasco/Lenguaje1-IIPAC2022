
int contador = 1;
int sumaImpares = 0;

while(contador <= 100)
{
    if (contador % 2 != 0)
    {
        Console.WriteLine("Número impar: " + contador);
        sumaImpares += contador;
    }
    contador += 1;
}

Console.WriteLine("La suma es: {0}", sumaImpares);
