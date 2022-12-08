// Задача 46: Задайте двумерный массив размером m*n,
// заполненый случайными целыми числами.
//   m = 3, n = 4.
// 1   4   8   19
// 5  -2  33   -2
// 77  3   8   1

int[,] CreatMatrixRndint()
{
    int[,] matrix = new int[3, 4];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(-50, 51);
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}  ");
        }
        Console.WriteLine("]");
    }
}

int[,] array2D = CreatMatrixRndint();
PrintMatrix(array2D);