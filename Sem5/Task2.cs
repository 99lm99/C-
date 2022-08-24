// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19 [-4, -6, 89, 6] -> 0

int size = 4;
int[] numbers = new int [size];
int sum = 0;

FillArrayRandom(numbers);
PrintArray(numbers);

for (int i = 0; i < numbers.Length; i++)
{
    sum = numbers[1] + numbers[3];
}
Console.WriteLine();
Console.WriteLine(sum);


void FillArrayRandom(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 10);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
