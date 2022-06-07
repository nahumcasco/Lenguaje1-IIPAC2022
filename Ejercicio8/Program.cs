Console.WriteLine("Siclo While\n");

int contador = 1;
while(contador <= 100)
{
    Console.WriteLine(contador);
    //contador = contador + 1;
    
    //contador += 1;
    contador++;
}

Console.WriteLine("Inversa\n");

int contador2 = 100;
while(contador2 >= 1)
{
    Console.WriteLine(contador2);
    contador2 -= 1;
}

Console.WriteLine("Números del 1 al 100 (Pares)");
int numero = 1;

while(numero <= 100)
{
    if(numero % 2 == 0)
    {
        Console.WriteLine(numero + " es par");
    }
    //numero++;
    numero = numero + 1;
}
Console.WriteLine("\n");
Console.WriteLine("Suma de los Números del 1 al 100");

int contador3 = 1;
int suma = 0;

while(contador3 <= 100)
{
    suma += contador;
    contador3++;
}

Console.WriteLine("La suma es: " + suma);


