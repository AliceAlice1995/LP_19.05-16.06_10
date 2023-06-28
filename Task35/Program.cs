int UserInput(string str)
{
    Console.WriteLine(str);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int number = UserInput("Введите натуральное число: ");
int number2 = UserInput("Введите положителбное число: ");
int number3 = UserInput("Введите отрицателбное число: ");
Console.WriteLine(number);