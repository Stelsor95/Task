// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.

// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

// string Binary(int numb)
// {
//     string bin = string.Empty;
//     while (numb > 0)
//     {
//         bin = numb % 2 + bin;
//         numb /= 2;
//     }
//     return bin;
// }

int[] Binary(int numb)
{
    int numb1 = numb;
    int digits = 0;
    while (numb1 > 0)
    {
        numb1 /= 2;
        digits += 1;
    }

    int[] bin = new int[digits];
    for (int i = 0; i < bin.Length; i++)
    {
        bin[bin.Length - i - 1] = numb % 2;
        numb /= 2;
    }
    return bin;
}

void PrintArray(int[] bin)
{
    for (int i = 0; i < bin.Length; i++)
    {
        Console.Write(bin[i]);
    }
}

int[] binary = Binary(number);
PrintArray(binary);
// Console.WriteLine(Binary(number));