// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("введите число A: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число B: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int Step(int a, int b)
{
    int step = a;
    for (int i = 1; i < b; i++)
    {
        step = step * a;
    }
    return step;
}

int result = Step(num1, num2);
Console.WriteLine("A в степени B равно: " + result);