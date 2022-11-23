// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит
//  расстояние между ними в 3D пространстве.

// Нарпимер:
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите точку XA: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите точку YA: ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите точку ZA: ");
double za = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите точку XB: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите точку YB: ");
double yb = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите точку ZB: ");
double zb = Convert.ToDouble(Console.ReadLine());

double Distance(double xa1, double ya1, double za1, double xb1, double yb1, double zb1)
{
    double xc = (xa1 - xb1) * (xa1 - xb1);
    double yc = (ya1 - yb1) * (ya1 - yb1);
    double zc = (za1 - zb1) * (za1 - zb1);
    double result = Math.Sqrt(xc + yc + zc);
    return result;
}

double res = Distance(xa, ya, za, xb, yb, zb);
double resRound = Math.Round(res, 2, MidpointRounding.ToZero);
Console.WriteLine(resRound);