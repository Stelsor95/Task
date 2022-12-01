// 30: Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.

// [1, 0, 1, 1, 0, 1, 0, 0]

void RandomArray(int[] collection)
{
    Random rnd = new Random();
    for (int index = 0; index < collection.Length; index++)
    {
        collection[index] = rnd.Next(0, 2);
    }
}

void PrintArray(int[] col)
{
    Console.Write("[");
    for (int position = 0; position < col.Length; position++)
    {
        if (position < col.Length - 1) Console.Write($"{col[position]}, ");
        else Console.Write($"{col[position]}");
    }
    Console.Write("]");
    Console.WriteLine();
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

PrintArray(array);
RandomArray(array);
PrintArray(array);