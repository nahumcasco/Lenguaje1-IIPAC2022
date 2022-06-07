//Calcular la distacia que recorrerá un carro, que va a una velocidad constante de
// 80 k/h en 4 horas

decimal distancia, velocidad, tiempo;

Console.Write("Ingrese la velocidad: ");
velocidad = decimal.Parse(Console.ReadLine());

Console.Write("Ingrese el tiempo: ");
tiempo = decimal.Parse(Console.ReadLine());

distancia = velocidad * tiempo;

Console.Write("La distancia es: " + distancia);
Console.ReadLine();
Console.Write("La distancia es: {0}", distancia);
Console.ReadLine();
