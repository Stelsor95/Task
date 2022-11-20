// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.

// Например:
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введитн второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

// bool Multyplicity(int num1, int num2)
// {
//     if (num1 % num2 == 0) return true;
//     return false;
// }

// Console.WriteLine(Multyplicity(a, b) ? "Кратно" : $"Не кратно, остаток = {a % b}");

int MultyplicitySecond(int num1, int num2)
{
    return num1 % num2;
}

int result = MultyplicitySecond(a, b);
Console.WriteLine(result == 0 ? "Кратно" : $"Не кратно, остаток = {result}");