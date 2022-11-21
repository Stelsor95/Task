// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// Например:
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 6 || number == 7) Console.WriteLine("Этот день является выходным");
else if (number > 7) Console.WriteLine("Такого дня недели нет");
else if (number < 1) Console.WriteLine("Ну ты и ебобо, отрицательных дней не бывает");
else Console.WriteLine("Увы, но это рабочий день!");