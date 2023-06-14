// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number <= 0)
{
    Console.WriteLine("Введено некорректное число");
    return;
}

int Faktorial(int num) // num = number
{
    int fak = 1;
    for (int i = 1; i <= num; i++)
    {
        checked 
        {
            fak *= i;
        }
    }
    return fak;
}


int faktorial = Faktorial(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {faktorial}");
