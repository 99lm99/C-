/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

int x1 = ReadInt("Введите координату х первой точки: ");
int y1 = ReadInt("Введите координату y первой точки: ");
int z1 = ReadInt("Введите координату z первой точки: ");
int x2 = ReadInt("Введите координату х второй точки: ");
int y2 = ReadInt("Введите координату y второй точки: ");
int z2 = ReadInt("Введите координату z второй точки: ");


double lenght = Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1) + (z2 - z1)*(z2 - z1));
Console.WriteLine(lenght);

int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}
