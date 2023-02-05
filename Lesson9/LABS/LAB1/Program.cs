// Задача 63. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N. 
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int InputNumber(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void PrintNumbers(int number)
{
    
    for(int i = 1; i <= number; i++)
    {
        Console.Write($"{i}, ");
    }
}

int number = InputNumber("Введите число: ");
System.Console.WriteLine(number);

PrintNumbers(number);