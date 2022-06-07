int numero = 0;
int mayor = 0;

do
{
    Console.WriteLine("Ingrese un número: ");
    numero = Convert.ToInt32(Console.ReadLine());

    if(numero > mayor)
    {
        mayor = numero;
    }
} 
while (numero != 0);

Console.WriteLine("El número mayor de todos los ingresados es: {0}", mayor);


