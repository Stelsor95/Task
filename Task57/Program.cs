// Задача 57: Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается
// элемент входных данных.

int[,] CreatMatrixRndint()
{
    int[,] matrix = new int[4, 4];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j]}, ");
            else Console.Write($"{matrix[i, j]}");
        }
        Console.WriteLine("]");
    }
}

int[] MatrixToArray(int[,] matrix)
{
    int[] arr = new int[matrix.Length];
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arr[k++] = matrix[i, j];
        }
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
    Console.WriteLine("] ");
}

void CountValue(int[] arr)
{
    int count = 0;
    int num = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num)
        {
            count++;
        }
        else
        {
            Console.WriteLine($"{num} встечается {count} раз");
            num = arr[i];
            count = 1;
        }
    }
    Console.WriteLine($"{num} встечается {count} раз");
}

int[,] array2D = CreatMatrixRndint();
PrintMatrix(array2D);
Console.WriteLine();
int[] array = MatrixToArray(array2D);
Array.Sort(array);
PrintArray(array);
Console.WriteLine();
CountValue(array);