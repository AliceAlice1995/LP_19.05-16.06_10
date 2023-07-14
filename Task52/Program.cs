// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
    //   0 1 2 3
// 0  1 4 7 2          00/ 10/ 20 
// 1  5 9 2 3          01/ 11/ 21
// 2  8 4 2 4          02/ 12/ 22
                    // 03/ 13/ 23
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrixArrayRndInt(int rows, int columns, int min, int max) // rows = 3 columns = 4
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

void CountMiddle(double[] arr)
{
    for (int i = 0; i < arr.Length; i++) 
    {
        Console.WriteLine($"Среднее арифметическое элементов в {i+1} столбце = {arr[i]}");
    }
}

double[] CountMiddleInColumn(int[,] arr)
{
    double[] middle = new double[arr.GetLength(0)];
    double sum = 0;

    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++) sum += arr[j,i];

        middle[i] = sum / arr.GetLength(0);
        sum = 0;
    }
    return middle;
}



int[,] array2d = CreateMatrixArrayRndInt(4, 4, -10, 10);
PrintMatrix(array2d);
double[] middleColumn = CountMiddleInColumn(array2d);
CountMiddle(middleColumn);