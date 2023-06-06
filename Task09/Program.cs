// 9. Напишите программу, которая 
// 1. получить случайное число
// 2. вывести случайное число из отрезка [10, 99] 
// 3. показывает наибольшую цифру числа.

// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10,100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 -> {number}");
// int firstDigit = number / 10;
// int secondDigit = number % 10;
// if(firstDigit > secondDigit) 
//     Console.WriteLine($"Наибольшая цифра числа -> {firstDigit}");
// else 
//     Console.WriteLine($"Наибольшая цифра числа -> {secondDigit}");

// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");

int MaxDigit(int num) 
{
    int firstDigit = num / 10;
    int secondDigit = num % 10; 
    int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
    return maxDigit;
}

int maxDigit1 = MaxDigit(76);
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit1}");

int maxDigit2 = MaxDigit(89);
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit2}");