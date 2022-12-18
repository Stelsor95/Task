// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int number = InputNumbers("Введите натуральное число: ");

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

Console.WriteLine();
NatualNumbers(number);

void NatualNumbers(int num)
{
    if (number < 0) Console.Write($"{number} не натуральное число");
    if (num > 0)
    {
        Console.Write($"{num} ");
        NatualNumbers(num - 1);
    }
}