// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if ( number >= 100 && number <1000)
{
    int result = SecondDigit(number);
    Console.WriteLine($"Вторая цифра числа -> {result}");
}
else 
{
    Console.WriteLine("Некорректное число.");
}


int SecondDigit(int num)
{
    int DevByTen = num / 10;
    int res = DevByTen % 10;
    return res;
}