// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.

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
    if (num > 0)
    {
        NatualNumbers(num - 1);
        Console.Write($"{num} ");
    }
}