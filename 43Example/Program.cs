// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значения b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значения k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значения b2");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значения k2");
double k2 = Convert.ToDouble(Console.ReadLine());

if (k2 - k1 == 0)
{
    Console.Write($"Прямые не пересекаются в точке, они паралельны");
}
else
{
    double x = searchX(k1, b1, k2, b2);
    double y = searchY(k1, b1, k2, b2);
    Console.Write($"Прямые пересекаются в точке {x} {y}");
}

double searchX(double a1, double c1, double a2, double c2)
{
    double x = Math.Round(-(c2 - c1) / (a2 - a1),2);
    return x;
}

double searchY(double a1, double c1, double a2, double c2)
{
    double y = Math.Round(-(a1 * c2 - a2 * c1) / (a2 - a1),2);
    return y;
}