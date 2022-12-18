// Задача 65: адайте значение M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.

int numberM = InputNumbers("Введите натуральное число M: ");
int numberN = InputNumbers("Введите натуральное число N: ");

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

Console.WriteLine();
NatualNumbers(numberM, numberN);

void NatualNumbers(int numM, int numN)
{
    if (numN > numM)
    {

        NatualNumbers(numM, numN - 1);
        Console.Write($"{numN} ");

    }

    if (numN < numM)
    {

        Console.Write($"{numM} ");
        NatualNumbers(numM - 1, numN);

    }

    if (numN == numM)
        Console.Write($"{numN} ");
}