﻿// 7. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.

// Например:
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int last = num % 10;
Console.WriteLine($"Последняя цифра числа {num} это {last}");