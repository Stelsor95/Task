// Задача 51: Задайте двумерный массив. Найдите суммму элементов,
// находящихся на главной диагонали (с индексами (0, 0); (1; 1) и т.д.

int[,] CreatMatrixRndint()
{
    int[,] matrix = new int[3, 4];
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

// Вариынт 1
// int SumDiagonalMatrix(int[,] matrix)
// {
//     int sum = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i == j)
//                 sum += matrix[i, j];
//         }
//     }
//     return sum;
// }

// Вариынт 2
// int SumDiagonalMatrix(int[,] matrix)
// {
//     int minIndex = matrix.GetLength(0);
//     int sum = 0;
//     if (matrix.GetLength(0) > matrix.GetLength(1)) minIndex = matrix.GetLength(1);
//     for (int i = 0; i < minIndex; i++)
//         sum += matrix[i, i];
//     return sum;
// }

// Вариынт 3
int SumDiagonalMatrix(int[,] matrix)
{
    int minIndex = matrix.GetLength(0) < matrix.GetLength(1)
    ? matrix.GetLength(0) : matrix.GetLength(1);
    int sum = 0;
    for (int i = 0; i < minIndex; i++)
        sum += matrix[i, i];
    return sum;
}

int[,] array2D = CreatMatrixRndint();
PrintMatrix(array2D);
Console.WriteLine();
Console.WriteLine($"Суммма элементов, находящихся на главной диагонали = {SumDiagonalMatrix(array2D)}");