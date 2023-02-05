// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int InputNumber(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int FindSumm(int m, int n)
{
    if (m > n)
        return 0;

    return m + FindSumm(++m, n);
}

int m = InputNumber("Введите число M: ");
int n = InputNumber("Введите число N: ");

if (m > n)
{
    int temp = m;
    m = n;
    n = temp;
}

System.Console.WriteLine(FindSumm(m, n));


//4, 8 -> 4 + 5 + 6 + 7 + 8 = 30
