// Задача 27: Напишите программу, которая принимает на вход число и выдаёт 
// сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumOfDigit(int num)
{
    int res = 0;
    while(num != 0) 
    {
        res = res + num % 10;
        num = num / 10;
    }
    return res;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 10) 
{
    Console.WriteLine("Введено одночастное число!");
    return;
}

int sum = SumOfDigit(number);
Console.WriteLine($"{sum}");