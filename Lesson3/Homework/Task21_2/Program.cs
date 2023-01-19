// Задача 21 (способ решения через 2 функции, где внутри одной функции вызывается другая функция)
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

(double x, double y, double z) GetPointFromConsole(string message)
{
    Console.WriteLine(message);
    Console.WriteLine();

    double x = GetNumberFromConsole("x:");
    double y = GetNumberFromConsole("y:");
    double z = GetNumberFromConsole("z:");

    return (x , y, z);
}
int GetNumberFromConsole(string message)
{
    System.Console.WriteLine(message);
    return Int32.Parse(Console.ReadLine());
}
(double x, double y, double z) point1 = GetPointFromConsole("Введите точку A:");
(double x, double y, double z) point2 = GetPointFromConsole("Введите точку B:");

double answer = Math.Round(Math.Sqrt(Math.Pow(point2.x - point1.x,2) + 
    Math.Pow(point2.y-point1.y,2)+Math.Pow(point2.z - point1.z,2)),2);

Console.WriteLine("Расстояние между двумя точками в 3D пространстве: " + answer);


