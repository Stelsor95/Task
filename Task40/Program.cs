// Задача 40: Напишите программу, которая принмает на вход три числа чмсла
// и проверяет, может ли существовать треугольник с сторонами такой длины.

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

bool Triagnle(int a1, int b1, int c1)
{
    return a1 < b1 + c1 && b1 < a1 + c1 && c1 < a1 + b1;
}

string text = Triagnle(a, b, c) ? "Треугольник может существовать"
                                : "Треугольник не может существовать";

Console.WriteLine(text);