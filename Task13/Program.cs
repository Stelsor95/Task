// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//  Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// Например:
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int FirstDigit(int num)
{
    int secondDigit = num % 1000;
    int result = secondDigit / 100;
    return result;
}

if (number > 100) Console.WriteLine($"Третья цифра числа {number} это --> {FirstDigit(number)}");
else Console.WriteLine($"В числе {number} третьей цифры нет");