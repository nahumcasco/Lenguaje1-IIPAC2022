Console.WriteLine(" ***** Condicional IF ****** ");
//Aprueba con 70%

byte notaFinal = 0;

Console.Write("Ingrese el promedio final del estudiante: ");
notaFinal = Convert.ToByte(Console.ReadLine());

if (notaFinal >= 70)
{
    Console.WriteLine("El estudiante aprobó la clase.");
}
else
{
    Console.WriteLine("El estudiante no aprobó la clase.");
}