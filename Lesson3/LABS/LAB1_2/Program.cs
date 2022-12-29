// тип данных название (переменные, которые передаем)
// void
//
// Как записать функцию : тип данных, название (параметры)

Console.WriteLine("Наша программа");

int ReadValueWithMessage(string message)
{
    Console.WriteLine(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int x = ReadValueWithMessage("Введите координату x:");
int y = ReadValueWithMessage("Введите координату y:");

string answer = string.Empty;

if (x == 0 || y == 0)
{
    Console.WriteLine("WRONG!");
    return;
}

if (y > 0)
{
    answer = (x > 0) ? "Первая" : "Вторая";
}
else
{
    answer = (x < 0) ? "Третья" : "Четвертая";
}

Console.WriteLine(answer + " четверть"); 