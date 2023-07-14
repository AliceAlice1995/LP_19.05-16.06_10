// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.WriteLine("Введите натуральное число:");
int number = Convert.ToInt32(Console.ReadLine());

void RangeOfNaturalNumbers(int num) //5
{
    if 4(num == 0) return;
    Console.Write($"{num} ");
    RangeOfNaturalNumbers(num - 1);
}

if (number > 0)
{
    RangeOfNaturalNumbers(number);
}
else
{
    Console.WriteLine("Введено ненатуральное число!");
}