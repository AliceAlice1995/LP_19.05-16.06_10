// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int EnterNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
} 

int Exponentiation(int num, int exp)
{
    if (exp == 0) return 1;
    return num * Exponentiation(num, exp - 1);
}


int number = EnterNumber("Введите целое число:);
int exp = EnterNumber("Введите степень числа:");
Console.WriteLine($"{exp}я степень числа {number} = {Exponentiation(number, exp)}");