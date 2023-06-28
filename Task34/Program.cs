// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество чётных 
// чисел в массиве.
// [345, 897, 568, 234] -> 2

// 1. создать массив
int[] CreateArray(int lengthArray)
{
    int[] array = new int[lengthArray];
    return array;
}
// 1.1 напечатать массив
void PrintArray(int[] arr)
{   
    Console.Write("["); 
    // 1.1.1 обойти каждый элемент
    for (int i = 0; i < arr.Length; i++)
    {   
        if(i == arr.Length - 1)
        {
            // 1.1.1.1 вывести последний элемент 
            Console.Write($"{arr[i]}"); 
        }
        else
        {
            // 1.1.1.1 вывести непоследний элемент 
            Console.Write($"{arr[i]}, ");  
        }
    }
    Console.WriteLine("]"); 
}
// 2. заполнить его числами

// 3. проверить на четность

// 4. посчитать кол-во четных 

// 5. ВЫВЕСТИ

int[] arr = CreateArray(4);
PrintArray(arr);




