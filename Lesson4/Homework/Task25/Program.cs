﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int Degree(int numberA, int numberB)
{
    int result = 1;

    for (int i = 1; i <= numberB; i++)
    {
        result = Convert.ToInt32(Math.Pow(numberA, numberB));
    }
    return result;
}

System.Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int degree = Degree(numberA, numberB);
System.Console.WriteLine("Ответ: " + degree);