// 4)Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

Console.WriteLine("Введите число 1:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2:");
int b = Convert.ToInt32(Console.ReadLine());

int sqra = a * a;
int sqrb = b * b;

if(a == sqrb)
{
    Console.WriteLine("1 является квадратом 2");
}
else if(b == sqra)
{
    Console.WriteLine("2 является квадратом 1");
}
else
{
    Console.WriteLine("ничто не квадрат ничего");
}



