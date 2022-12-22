// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.WriteLine("Enter 3 digit number:");

int number = Convert.ToInt32(Console.ReadLine());

if(number < 100 || number > 999)
{
    System.Console.WriteLine("Incorrect number");
}
else
{
    number = number / 10 % 10;
}

System.Console.WriteLine(number)ж