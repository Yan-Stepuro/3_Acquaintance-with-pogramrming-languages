﻿// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int N = Convert.ToInt32(Console.ReadLine());
int one = 0;
int two = 1;

string answer = one + ", " + two;

for(int i = 0; i < N; i++)
{
    int temp = one;
    one = two;
    two += temp;
    answer += ", " + two;
}

System.Console.WriteLine(answer);