

Console.WriteLine("***********Evaluar si un número es Par o Impar.*************");

int numero = 0;

Console.Write("Ingrese un número: ");
//numero = int.Parse(Console.ReadLine());
numero = Convert.ToInt32(Console.ReadLine());

if(numero % 2 == 0)
{
    Console.WriteLine("El número ingresado es PAR.");
}
else
{
    Console.WriteLine("El número ingresado NO es PAR.");
}
Console.WriteLine();