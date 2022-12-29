// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] numberArray = number;

string result = "";

for(int i = 0; i < number.Length / 2; i++)
{
    if(number[i] == number[number.Length - 1 - i])
    {
        result = "да";
        System.Console.WriteLine(result);
    }
    else
    {
        result = "нет";
        System.Console.WriteLine(result);
        break;
    }
}
