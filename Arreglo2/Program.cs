
int[] numeros = { 8, 9, 12, 45, 7, 30 };

int suma = 0;

for (int i = 0; i < numeros.Length; i++)
{
    suma += numeros[i];
}

Console.WriteLine("La suma total de los valores del arreglo es: " + suma);
