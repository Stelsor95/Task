// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreatArrayRndint(int siz, int minX, int maxX)
{
    int[] arr = new int[siz];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(minX, maxX + 1);
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
    Console.Write("] -> ");
}

int ProjectArray(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum = sum + arr[i];
        }
    }
    return sum;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreatArrayRndint(size, min, max);

Console.WriteLine();
PrintArray(array);
Console.WriteLine(ProjectArray(array));