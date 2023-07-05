// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}


void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int SumOddElements(int[] inpArr)
{
    int sum = 0;
    for (int i = 1; i < inpArr.Length; i = i + 2)
    {
        sum = sum + inpArr[i];
    }
    return sum;
}

int[] array = CreateArrayRndInt(6, 0, 10);
PrintArray(array);

int result = SumOddElements(array);
Console.WriteLine($"Sum of the odd positions = {result}");