// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.

// Например:
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool Multyplicity(int num)
{
    if (num % 7 == 0 && num % 23 == 0) return true;
    return false;
}

Console.WriteLine(Multyplicity(number) ? "Кратно" : "Не кратно");