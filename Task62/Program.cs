﻿// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] sqareMatrix = new int[4, 4];

void SqareMatrix(int[,] sqareMatrix1)
{
    int temp = 1;
    int i = 0;
    int j = 0;
    while (temp <= sqareMatrix1.GetLength(0) * sqareMatrix1.GetLength(1))
    {
        sqareMatrix1[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < sqareMatrix1.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= sqareMatrix1.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > sqareMatrix1.GetLength(1) - 1)
            j--;
        else
            i--;
    }
}

SqareMatrix(sqareMatrix);
WriteArray(sqareMatrix);

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
                Console.Write($"0{array[i, j]} ");

            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}