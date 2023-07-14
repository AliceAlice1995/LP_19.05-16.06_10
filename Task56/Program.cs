// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max) // rows = 3 columns = 4
{
    //                       0       1
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 6} ");
        }
        Console.WriteLine("]");
    }
}

void PrintSum(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Сумма элементов в {i} строке: {array[i]}");
    }
}

int[] SumOfElementsInRows(int[,] array)
{
    int[] sum = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp += array[i,j];
        }
        sum[i] = temp;
    }
    return sum;
}

int GetIndexMinRow(int[] array)
{
    int indexMin = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < array[indexMin]) indexMin = i;
    }
    return indexMin;
}

int[,] array2d = CreateMatrixRndInt(4, 4, 1, 10);
PrintMatrix(array2d);

int[] SumByRow = SumOfElementsInRows(array2d);
PrintSum(SumByRow);

int indexMinRow = GetIndexMinRow(SumByRow);
Console.WriteLine($"Строка c наименьшей суммой элементов: {indexMinRow} строка");