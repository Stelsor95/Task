// Задача 69: Напишите программу, которая на вход принимает два числа A и B,
// и возводит число A в целую степень B с помощью рекурсии.

int numberA = InputNumbers("Введите натуральное число A: ");
int numberB = InputNumbers("Введите натуральное число B: ");

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

Console.WriteLine(DegreeNumber(numberA, numberB));

int DegreeNumber(int numA, int numB)
{
    return numB == 0 ? 1 : numA * DegreeNumber(numA, numB - 1);
}