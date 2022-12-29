//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09 A (7,-5); B (1,-1) -> 7,21

double ReadValueFromConsole(string message)
{
    System.Console.Write(message);
    double value = Convert.ToInt32(Console.ReadLine());
    return value;
}

double FindDistance(double x1, double y1, double x2, double y2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
}

double x1 = ReadValueFromConsole("X1 = ");
double y1 = ReadValueFromConsole("Y1 = ");

double x2 = ReadValueFromConsole("X2 = ");
double y2 = ReadValueFromConsole("Y2 = ");

System.Console.WriteLine(FindDistance(x1, y1, x2, y2));

