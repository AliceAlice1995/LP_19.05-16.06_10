// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.WriteLine("Введите первое число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число: ");
int step = Convert.ToInt32(Console.ReadLine());

if (step <= 0)
{
    Console.WriteLine("Введено не натуральное число!");
    return;
}

int res = CountStep(number, step);
Console.WriteLine($"Число {number} в степени {step} = {res}");

int CountStep(int num, int stepen)
{
    int result = 1;

    for (int i = 1; i <= stepen; i++)
    {
        result *= num;
    }

    return result;
}