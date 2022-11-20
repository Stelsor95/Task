// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.

// Например:
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

bool Square(int num1, int num2)
{
    if (num1 == num2 * num2 || num2 == num1 * num1) return true;
    return false;
}

Console.WriteLine(Square(a, b) ? "Да" : "Нет");