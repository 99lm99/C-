/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;

while (i <= N)
{
    if(i == N)
    {
        Console.Write(Math.Pow(i, 3));
    }
    else
    {
        Console.Write(Math.Pow(i, 3) + ", ");
    }
    i++;
}
