// 1)Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int SummFromOneDigitToNumber(int N)
{
    int summ = 0;

    for (int i = 1; i <= N; i++)
        summ += 1;

    return summ;
}

int GetNumberFromConsole(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}

int N = GetNumberFromConsole("A = ");
System.Console.WriteLine(SummFromOneDigitToNumber(N));
