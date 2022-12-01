// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.

// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] CreatArrayRndint()
{
    int[] arr = new int[5];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(1, 9);
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
    Console.Write("] ");
}

int[] NewArray(int[] arr)
{
    int size = arr.Length / 2;
    if (arr.Length % 2 == 1) size += 1;
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    if (arr.Length % 2 == 1) newArray[size - 1] = arr[arr.Length / 2];
    return newArray;
}

int[] array = CreatArrayRndint();
PrintArray(array);
int[] result = NewArray(array);
PrintArray(result);