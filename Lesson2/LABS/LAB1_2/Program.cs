// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine(number);

// int a = number / 100;
// int b = number % 10;

// Console.WriteLine(number);
// Console.WriteLine(a);
// Console.WriteLine(b);

// Console.Write(a);
// Console.Write(b);

int c = (number / 100) * 10 + (number % 10);
Console.Write(c);