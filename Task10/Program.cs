// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//  Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// Например:
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int FirstDigit(int num)
{
    int secondDigit = num % 100;
    int result = secondDigit / 10;
    return result;
}

Console.WriteLine($"Вторая цифра числа {number} это --> {FirstDigit(number)}");
