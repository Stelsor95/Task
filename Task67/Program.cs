// Задача 67: Напишите программу, которая будет принимать на вход 
// число и возвращает сумму его цифр.

int number = InputNumbers("Введите натуральное число: ");

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

Console.WriteLine(SumDigits(Math.Abs(number)));

int SumDigits(int num)
{
    return num != 0 ? num % 10 + SumDigits(num / 10) : 0;
}