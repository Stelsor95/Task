// 18:Напишите программу, которая по заданному номеру четверти,показывает 
// диапозон возможных координат точек в этой четверти (X и Y).

Console.Write("Введите число: ");
int quarter = Convert.ToInt32(Console.ReadLine());

string Renge(int quarter1)
{
    if (quarter1 == 1) return "x > 0 и y > 0";
    if (quarter1 == 2) return "x < 0 и y > 0";
    if (quarter1 == 3) return "x > 0 и y < 0";
    if (quarter1 == 4) return "x < 0 и y < 0";
    return "Введено некорректное число";
}

string renge = Renge(quarter);
Console.WriteLine(renge);