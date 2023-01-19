// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SummNumbers(int number)
{
    int counter = Convert.ToString(number).Length;
    int rest = 0;
    int result = 0;

    for(int i = 0; i < counter; i++)
    {
        rest = number - number % 10;
        result = result + (number - rest);
        number = number / 10;
    }
   
    return result;
}

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int summNumbers = SummNumbers(number);
System.Console.WriteLine("Сумма цифр: " + summNumbers);

