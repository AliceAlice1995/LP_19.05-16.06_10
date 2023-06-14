// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumOfNumbers = DigitOfNumbers(number);
Console.WriteLine();


int DigitOfNumbers(int num) 
{
    int digit = 0;
    if (num == 0) return 1;
    while (num != 0)
    {
        digit++;
        num /= 10;
    }
    return digit;
}


Console.WriteLine($"Число {number} содержит {sumOfNumbers} цифр");