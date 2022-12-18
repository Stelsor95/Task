// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int numberM = InputNumbers("Введите натуральное число M: ");
int numberN = InputNumbers("Введите натуральное число N: ");

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int AckermannFunction(int numM, int numN)
{
    if (numM == 0) return numN + 1;
    if (numM != 0 && numN == 0) return AckermannFunction(numM - 1, 1);
    if (numM > 0 && numN > 0) return AckermannFunction(numM - 1, AckermannFunction(numM, numN - 1));
    return AckermannFunction(numM, numN);
}

Console.WriteLine($"Функция Аккермана для чисел A({numberM},{numberN}) = {AckermannFunction(numberM, numberN)}");