// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]



void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
        if (i != arr.Length - 1) Console.Write(", ");
    }
    Console.WriteLine("]");
}

int[] FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random();
    }
    return array;
}

int Random()
{
    return new Random().Next();
}

int[] array = new int[5];
FillArray(array);
PrintArray(array);




// FillArray(int[] array)
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = i;
// }

// PrintArray(int[] array)
// for (int i = 0; i < array.Length; i++)
// {
//     Console.WriteLine(array[i]);
// }

// FillArray(array);
// PrintArray(array);