//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09 A (7,-5); B (1,-1) -> 7,21

double ReadValueFromConsole(string message)
{
    System.Console.WriteLine(message);
    double value = Convert.ToInt32(Console.ReadLine());
    return value;
}

double x1 = ReadValueFromConsole("Введите координаты")

double FindDistance(double x1, double y1, double x2, double y2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
}

