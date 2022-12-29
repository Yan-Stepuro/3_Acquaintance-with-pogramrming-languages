//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09 A (7,-5); B (1,-1) -> 7,21

double Qwe(string name)
{
    Console.WriteLine(name);
    double Ax  = Convert.ToDouble(Console.ReadLine());
    return Ax;
}

double Ax = Qwe("Введите Ax");
double Ay = Qwe("Введите Ay");
double Bx = Qwe("Введите Bx");
double By = Qwe("Введите Ay");

double AB = Math.Sqrt(Math.Pow((Bx - Ax), 2) + Math.Pow((By - Ay), 2));
Console.WriteLine(AB);


