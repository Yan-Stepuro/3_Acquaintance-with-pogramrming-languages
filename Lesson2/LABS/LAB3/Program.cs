// &&
// 3)Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int a = number % 7;
int b = number % 23;

if(a == 0 && b == 0)
{
    Console.WriteLine("Да");
}
else{
    Console.WriteLine("Нет");
}

