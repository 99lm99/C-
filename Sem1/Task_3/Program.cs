// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = 2;
if (numberA % numberB == 0)
    {
    Console.WriteLine("Четное");
    }
else
    {
    Console.WriteLine("Нечетное");
    }

