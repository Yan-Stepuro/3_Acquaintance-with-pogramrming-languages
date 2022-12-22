// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите координату X:");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y:");
int y = Convert.ToInt32(Console.ReadLine());

string answer = string.Empty;

if (x == 0 || y == 0)
{
    Console.WriteLine("Значения должны быть отлично от нуля!");
    return;
}

if (y > 0)
{
    answer = (x > 0)? "Первая" : "Вторая";
}
else
{
    answer = (x < 0) ? "Третья" : "Четвертая";
}

Console.WriteLine(answer + " четверть"); 