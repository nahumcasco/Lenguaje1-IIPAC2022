int[] numeros = { 5, 69, 45, 7, 81, 90, 10, 5, 50, 3 };

int sumaPar = 0;
int sumaImpar = 0;

for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] % 2 == 0) //Este es par
    {
        sumaPar += numeros[i];
    }
    else
    {
        sumaImpar = sumaImpar + numeros[i];
    }
}

Console.WriteLine("La suma total de los números pares es: \n" + sumaPar);
Console.WriteLine("La suma total de los números impares es: \n" + sumaImpar);

