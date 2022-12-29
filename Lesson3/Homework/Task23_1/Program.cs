// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int ReadValueFromConsole(string message)
{
    System.Console.WriteLine(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int result = 0;

int cube(int value)
{
    for(int i = 1; i <= value; i++)
    {
        int result = Convert.ToInt32(Math.Pow(i, 3));
        System.Console.WriteLine(result);
    }
    return result;
}

int value = ReadValueFromConsole("Введите число: ");
System.Console.WriteLine(cube(value));

//как убрать вывод лишнего нуля? 