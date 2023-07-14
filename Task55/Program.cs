// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

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

// void ReverseRows(int[,] matrix)
// {
//     int[,] tmpMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];

//     for (int i = 0; i < matrix.GetLength(1); i++)
//     {
//         for (int i = 0; i < matrix.GetLength(1); i++)
//         {
//             int temp = arr[i, j];
//             matrix[i, j] = arr[j, i];
//             matrix[j, i] = temp;
//         }
//     }
// }

void SwapRowsColumns(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0) - 1; i++)
    {
        for (int j = i + 1; j < arr.GetLength(1); j++)
        {
            int temp = arr[i, j];
            arr[i, j] = arr[j, i];
            arr[j, i] = temp;
        }
    }
}

bool IsMatrixSguare(int[,] matrix)
{
    return matrix.GetLength(0) == matrix.GetLength(1);
}

int[,] matr = CreateMatrixArrayRndInt(4, 4, 0, 10);
PrintMatrix(matr);
Console.WriteLine();
SwapRowsColumns(matr);
Console.WriteLine();
PrintMatrix(matr);
