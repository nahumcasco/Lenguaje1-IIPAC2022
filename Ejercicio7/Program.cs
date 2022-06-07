//Declarar las variables y las inicializamos en 0
int num1 = 0;
int num2 = 0;

//Título de la aplicación
Console.WriteLine("Calculadora Básica en C#.Net");
Console.WriteLine("-----------------------------\n");

//Pedimos al usuario el primer valor
Console.WriteLine("Escriba el primer número, y luego presione enter");
num1 = Convert.ToInt32(Console.ReadLine());

//Pedimos al usuario el segundo valor

Console.WriteLine("Escriba el segundo número, y luego presione enter");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Elija una opción de la siguiente lista:");
Console.WriteLine("\ta) -> Sumar");
Console.WriteLine("\tb) -> Resta");
Console.WriteLine("\tc) -> Multiplicar");
Console.WriteLine("\td) -> Dividir");
Console.Write("Su opción es: ");

switch (Console.ReadLine())
{
    case "a":
        Console.WriteLine($"El resultado: {num1} + {num2} = " + (num1 + num2));
        break;

    case "b":
        Console.WriteLine($"El resultado: {num1} - {num2} = " + (num1 - num2));
        break;

    case "c":
        Console.WriteLine($"El resultado: {num1} * {num2} = " + (num1 * num2));
        break;

    case "d":
        while (num2 == 0)
        {
            Console.WriteLine("Ingrese un número diferente de cero.");
            num2 = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine($"El resultado: {num1} / {num2} = " + (num1 / num2));
        break;
}
Console.Write("Presiona una tecla para salir.");
Console.ReadKey();


