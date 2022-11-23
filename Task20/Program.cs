// 20:Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 2D пространстве. 

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1); -> 7,21

// int n = N;
// double res = Math.Sqrt(n);
// double nround = Math.Round(res, n, MidpointRounding.ToEven);

// Console.WriteLine(res);
// Console.WriteLine(nround);

Console.Write("Введите точку XA: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите точку YA: ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите точку XB: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите точку YB: ");
double yb = Convert.ToDouble(Console.ReadLine());

double Distance(double xa1, double ya1, double xb1, double yb1)
{
    double xc = (xa1 - xb1) * (xa1 - xb1);
    double yc = (ya1 - yb1) * (ya1 - yb1);
    double result = Math.Sqrt(xc + yc);
    return result;
}

double res = Distance(xa, ya, xb, yb);
double resRound = Math.Round(res,2, MidpointRounding.ToZero);
Console.WriteLine(resRound);