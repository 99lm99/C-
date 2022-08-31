/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

int rows = ReadToInt("Введите количество строк: ");
int cols = ReadToInt("Введите количество столбцов: ");
double[,] numbers = new double [rows,cols];

FillArray2D(numbers);
PrintArray2D(numbers);


int ReadToInt(string message)
{
Console.Write (message);
return Convert.ToInt32(Console.ReadLine());
}

void FillArray2D(Double[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
array[i, j] = new Random().NextDouble() * 10;
}
}
}

void PrintArray2D(Double[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
Console.Write(Math.Round(array[i, j], 1) + " ");
}
Console.WriteLine();
}
Console.WriteLine();
}
