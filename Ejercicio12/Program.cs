int numero = 0;
int suma = 0;
int cantidad = 0;
int promedio = 0;

do
{
    Console.WriteLine("Ingrese un número: ");
    numero = Convert.ToInt32(Console.ReadLine());

    if (numero != 0)
    {
        suma = suma + numero;
        cantidad++;
    }
}
while (numero != 0);

promedio = suma / cantidad;

Console.WriteLine("El promedio de los números ingresados es: {0}", promedio);
