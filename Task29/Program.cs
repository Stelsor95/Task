// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

void RandomArray(int[] collection)
{
    Random rnd = new Random();
    for (int index = 0; index < collection.Length; index++)
    {
        collection[index] = rnd.Next(1, 99);
        Console.Write($"{collection[index]} ");
    }
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

RandomArray(array);