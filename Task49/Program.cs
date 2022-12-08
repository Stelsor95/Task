// Задача 49: Задайте двумерный массив. Найдите элементы, у которых
// оба индекса четные, и замените эти элементы на их квадраты.

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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}  ");
        }
        Console.WriteLine("]");
    }
}

void SquareEvenNumbersMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
                matrix[i, j] *= matrix[i, j];
        }
    }
}

int[,] array2D = CreatMatrixRndint();
PrintMatrix(array2D);
Console.WriteLine();
SquareEvenNumbersMatrix(array2D);
PrintMatrix(array2D);