// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.WriteLine("Введите число:");
string numberInString = Console.ReadLine();

if (numberInString.Length < 3)
{
    System.Console.WriteLine("Третьей цифры нет");
    return;
}

System.Console.WriteLine(numberInString[2]);