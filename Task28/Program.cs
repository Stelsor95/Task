// 28: Напишите программу, которая принимает на вход число N
//  и выдает производные чисел от 1 до N.

//  4 -> 24
//  5 -> 120

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int MultDigits(int num)
{
    int mult = 1;
    for (int i = 1; i <= num; i++)
    {
        mult = mult * i;
    }
    return mult;
}

if (number > 0)
{
    int result = MultDigits(number);
    Console.WriteLine($"{number} -> {result}");
}

else Console.WriteLine("ОШИБКА: Введено отрицательное число");