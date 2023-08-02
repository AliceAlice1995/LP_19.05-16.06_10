// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое натуральное число M");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число N");
int number2 = Convert.ToInt32(Console.ReadLine());
int sum = 0;

int SumOfNumbers(int min, int max)
{
    if (min == max) return min;
    else return min + SumOfNumbers(min + 1, max);
}

if (number1 > 0 && number2 > 0)
{
    if (number1 > number2)
    {
        sum = SumOfNumbers(number2, number1);
    }
    else
    {
        sum = SumOfNumbers(number1, number2);
    }
    Console.WriteLine($"Сумма: {sum}");
} 
else Console.WriteLine("Одно или оба числа - ненатуральные!");



