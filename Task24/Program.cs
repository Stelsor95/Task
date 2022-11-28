// 24: Напишите программу, которая принимает на вход число (A)
//  и выдает сумму чисел от 1 до A.

// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigits(int num)
{
    int sum = default;
    for (int i = 1; i <= num; i++)
    {
        sum = sum + i;
    }
    return sum;
}

if (number > 0)
{
    int result = SumDigits(number);
    Console.WriteLine($"{number} -> {result}");
}

else Console.WriteLine("ОШИБКА: Введено отрицательное число");