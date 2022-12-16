//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Enter number");
int number = Convert.ToInt32(Console.ReadLine());

int i = 2;

for(i = 2; i <= number; i = i + 2)
{
    Console.WriteLine(i);
}