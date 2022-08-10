// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int numberC = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    if (numberA > numberC)
    {
        Console.Write(" max = " + numberA);
    }
    else 
    {
        Console.Write(" max = " + numberC);
    }
}
else if (numberB > numberC)
{
    Console.Write("max = " + numberB);
}
else
{
    Console.Write("max = " + numberC);
}

