/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет. Во вводе первая цифра - номер строки, вторая - столбца. Цифры не больше 9.
Например, задан массив: 
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */
int rows = new Random().Next(0, 10);
int cols = new Random().Next(0, 10);
int[,] numbers = new int [rows,cols];
FillArray2D(numbers);
PrintArray2D(numbers);
int a = ReadInt("Введите первую цифру от 1 до 9: ");
int b = ReadInt("Введите вторую цифру от 1 до 9: ");

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for(int j = 0; j < numbers.GetLength(1); j++)
    {
        if((a < rows && b < cols))
        {
            Console.Write(numbers.GetValue(a,b));
            break;
        }
        else
        {
            Console.WriteLine("Такого числа нет");
        }
    
    }

}



void FillArray2D(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
array[i, j] = new Random().Next(0, 10);
}
}
}

void PrintArray2D(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
Console.Write(array[i, j] + " ");
}
Console.WriteLine();
}
Console.WriteLine();
}
