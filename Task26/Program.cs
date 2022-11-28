// 26: Напишите программу, которая принимает на вход число
//  и выдает количество цифр в числе.

//  456 -> 3
//  78 -> 2
// 89126 -> 5

// Способ №1 -->
//
// Console.Write("Введите число: ");
// string number = (Console.ReadLine()!);
// int length = number.Length;
// Console.WriteLine($"В числе {number} -> цифор {length}");

// Способ №2 -->
//
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
//
// int NumberLength(int num)
// {
//     int count = 1;
//     for (int i = 0; i < 10; i++)
//     {
//         num = num / 10;
//         if (num != 0)
//         {
//             count++;
//         }
//         else break;
//     }
//     return count;
// }
//
// int result = NumberLength(number);
// Console.WriteLine($"В числе {number} -> цифор {result}");

// Способ №3 -->
//
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int NumberLength(int num)
{
    int count = 0;
    while (num != 0)
    {
        num = num / 10;
        count++;
    }
    return count == 0 ? 1 : count;
}

int result = NumberLength(number);
Console.WriteLine($"В числе {number} -> цифор {result}");