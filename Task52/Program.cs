// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите размер строки: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
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

void ArithmeticMean(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double summaArithmeticMean = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            summaArithmeticMean += matrix[i, j];
        }
        double resultMathRound = Math.Round(summaArithmeticMean / matrix.GetLength(0), 2);
        Console.WriteLine($"Среднее арифметическое столбца {j} ----> {resultMathRound} ");
    }
}

int[,] creatMatrixRndInt = CreateMatrixRndInt(rows, columns, min, max);

Console.WriteLine();
PrintMatrix(creatMatrixRndInt);
ArithmeticMean(creatMatrixRndInt);