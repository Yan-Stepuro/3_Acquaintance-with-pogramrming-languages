// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

//Console.Write("Generated number1: ");
int number1 = new Random().Next(1, 10);
//Console.WriteLine(number1);

//Console.Write("Generated number2: ");
int number2 = new Random().Next(0, 10);
//Console.WriteLine(number2);

//Console.Write("Generated number3: ");
int number3 = new Random().Next(0, 10);
//Console.WriteLine(number3);

Console.Write("Generated number: ");
int number = Convert.ToInt32(Convert.ToString(number1) + Convert.ToString(number2) + Convert.ToString(number3));
Console.WriteLine(number);

Console.Write("Result: ");
int result = Convert.ToInt32(Convert.ToString(number1) + Convert.ToString(number3));
Console.WriteLine(result);