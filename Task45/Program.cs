// Задача 45: Напишите программу, которая будет создавать копию заданного
// массива с помощью поэлементного копирования.

int[] CreatArrayRndint()
{
    int[] arr = new int[5];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(1, 100);
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

int[] CopuArray(int[] arr)
{
    int[] tempArray = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        tempArray[i] = arr[i];
    }
    return tempArray;
}

int[] array1 = CreatArrayRndint();
PrintArray(array1);
int[] array2 = CopuArray(array1);
PrintArray(array2);