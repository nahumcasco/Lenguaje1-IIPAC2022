//Declarar Arreglos
int[] arreglo1 = new int[10];

//Asignar Valores
arreglo1[0] = 80;
arreglo1[1] = 74;
arreglo1[2] = 32;
arreglo1[3] = 56;
arreglo1[4] = 87;
arreglo1[5] = 21;
arreglo1[6] = 89;
arreglo1[7] = 32;
arreglo1[8] = 9;
arreglo1[9] = 12;

int[] arreglo2 = new int[3] { 42, 31, 40 };
int[] arreglo3 = new int[] { 42, 31, 40 };
int[] arreglo4 = { 41, 62, 45, 87 };

for (int i = 0; i < arreglo1.Length; i++)
{
    Console.WriteLine(arreglo1[i]);
}
Console.WriteLine("\n\n");

string[] diasSemana = new string[7];

for (int i = 0; i < diasSemana.Length; i++)
{
    Console.Write("Ingrese un dia de la semana: ");
    string dia = Console.ReadLine();
    diasSemana[i] = dia;
}

Console.WriteLine("Los dias ingresados son");

for (int i = 0; i < diasSemana.Length; i++)
{
    Console.WriteLine(diasSemana[i]);
}
