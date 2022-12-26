﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.WriteLine("Введите 3 значное число:");

int number = Convert.ToInt32(Console.ReadLine());

if(number < 100 || number > 999)
{
    System.Console.WriteLine("Неверное число");
}
else
{
    number = number / 10 % 10;
}

System.Console.WriteLine(number);