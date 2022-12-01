// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.

// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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
    Console.WriteLine("]");
}

bool FindNumberArray(int[] arr, int numb)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == numb) return true;
    }
    return false;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число которое ищите: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = CreatArrayRndint(size, min, max);

Console.WriteLine();
PrintArray(array);

string result = FindNumberArray(array, number) ? "В этом массиве присутствует это число"
                                                    : "Нет в этом массиве не присутствует это число";
Console.WriteLine(result);