// SЗадача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2       1, -7, 567, 89, 223 -> 4

string NumbersM = ReadCommand("Введите числа через запятую: ");
int[] numbers = new int[NumbersM.Length];

int count = 0;
for (int i = 0; i < NumbersM.Length; i++)
{
    numbers[i] = NumbersM[i];
    if (numbers[i] > 0 && numbers[i] != ',') 
    count++;
}
Console.Write(count);

string ReadCommand(string message)
{
    Console.Write(message);
    return Console.ReadLine();
}
