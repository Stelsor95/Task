// 22:Напишите программу, которая принимает на вход число (N) и выдает таблицу
// квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1, 4.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void Square(int num)
{
    for (int count = 1; count <= num; count++)
    {
        Console.WriteLine($"{count} -> {count * count}");
    }
}

Square(number);