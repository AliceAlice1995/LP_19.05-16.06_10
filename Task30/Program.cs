// int[] array = new int[8]; // 0 1 2 3 4 5 6 7 
// int size = array.Length; // 8
// array[0] = 5343;
// array[7] = 67;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = i * i;
// }

// for (int i = 0; i < array.Length; i++)
// {
//     Console.WriteLine(array[i]);
// }



// int[] array1 = new int[8]{2, 5, 6, 5, 7, 9, 9, 6};
// int[] array2 = new int[]{2, 5, 6, 5, 7, 9, 9, 6, 8, 7};
// int[] array3 = {2, 5, 6, 5, 7, 9, 9, 6, 8, 7};


// var array4 = new int[8];
// int rnd = new Random().Next();


// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


// int[] array = new int[8]; // 0 1 2 3 4 5 6 7 
// int size = array.Length; // 8
// // int rnd = new Random().Next();

void FillArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(2);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}


int[] array1 = new int[8];
FillArray(array1);
PrintArray(array1);