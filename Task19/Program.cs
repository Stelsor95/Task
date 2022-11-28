// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// Нарпимер:
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите число: ");
// string number = Console.ReadLine();
// int len = number.Length;

// if (len == 5)
// {
//     if (number[0] == number[4] && number[1] == number[3])
//     {
//         Console.WriteLine($"{number} - Палиндром");
//     }

//     else
//     {
//         Console.WriteLine($"{number} - НЕ палиндром");
//     }
// }
// else
// {
//     Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
// }

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

void CheckPalindromicNumber(int num)
{
    if (num >= 10000 && num <= 99999)
    {
        int division1 = num / 10000;
        int remainder1 = num % 10;

        if (division1 == remainder1)
        {
            num = num / 10;
            int division2 = (num / 100) % 10;
            int remainder2 = num % 10;
            if (division2 == remainder2) Console.WriteLine("является палиндромом");
        }

        else Console.WriteLine("Не является палиндромом");

    }

    else Console.WriteLine("Некорректное число!");
}

CheckPalindromicNumber(number);