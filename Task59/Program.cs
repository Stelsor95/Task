// Задача 59: Задайте двумерный массив из целых чисел. Напишите
// программу, которая удалит строку и столбец, на пересечении которых
// расположен наименьший элемент массива.

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

void RowColumnIndexMinElem(int[,] matrix, out int indexRow, out int indexColumn)
{
    int min = matrix[0, 0];
    indexRow = 0;
    indexColumn = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                indexRow = i;
                indexColumn = j;
            }
        }
    }
}

int[,] DeieteRemoveRowColumnsMatrix(int[,] matrix, int indexRow, int indexColumn)
{
    int[,] matrix3 = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    for (int i = 0, m = 0; i < matrix.GetLength(0) - 1; i++, m++)
    {
        if (m == indexRow) m++;
        for (int j = 0, n = 0; j < matrix.GetLength(1) - 1; j++, n++)
        {
            if (n == indexColumn) n++;
            matrix3[i, j] = matrix[m, n];
        }
    }
    return matrix3;
}

int[,] array2D = CreatMatrixRndint();
PrintMatrix(array2D);
Console.WriteLine();
RowColumnIndexMinElem(array2D, out int indexRow, out int indexColumn);
Console.WriteLine($"Минимальное число {array2D[indexRow, indexColumn]}");
Console.WriteLine();
int[,] matrix2 = DeieteRemoveRowColumnsMatrix(array2D, indexRow, indexColumn);
PrintMatrix(matrix2);