// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 4 16, 4 -> кратно

Console.WriteLine("Введите число 1:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2:");
int number2 = Convert.ToInt32(Console.ReadLine());

int number = number2 % number1;

if (number == 0)
{
   Console.WriteLine(number2); 
   Console.WriteLine(number1); 
   Console.WriteLine("кратно"); 
}
else 
{
    Console.WriteLine("не кратно, остаток = " + number);
}