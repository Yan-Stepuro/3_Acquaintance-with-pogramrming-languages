//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет
Console.WriteLine("Welcome to the number-recognizer! This super intelligent programm will help you to find out weather entered number even or odd! Let's go!");
Console.WriteLine("=========================================================================================================================================");

Console.WriteLine("Enter your number:");
int number = Convert.ToInt32(Console.ReadLine());

int result = number % 2;

if ( result == 0 ) 
{
    Console.WriteLine("even");
}
else
{
    Console.WriteLine("odd");
}