// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int EnterCoef(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

double FindX(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}

double FindY(double k1, double b1, double x)
{
    double y = k1 * x + b1;
    return y;
}

void Result(double k1, double b1, double k2, double b2)
{
    double x = FindX(k1, b1, k2, b2);
    double y = FindY(k1, b1, x);
    System.Console.WriteLine($"{x} , {y}");
}

double b1 = EnterCoef("Введите значение b1: ");
double k1 = EnterCoef("Введите значение k1: ");
double b2 = EnterCoef("Введите значение b2: ");
double k2 = EnterCoef("Введите значение k2: ");

Result(k1, b1, k2, b2);
