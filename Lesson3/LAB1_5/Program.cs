int ReadValueWithMessage(string message)
{
    Console.WriteLine(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

string CheckGraphicArea(int x, int y)
{
    if (y > 0 && x > 0)
        return "Первая";
    if (y > 0 && x < 0)
        return "Вторая";
    if (y < 0 && x < 0)
        return "Третья";
    if (y < 0 && x > 0)
        return "Четвертая";
    
    return String.Empty;
}

int x = ReadValueWithMessage("Введите координату x:");
int y = ReadValueWithMessage("Введите координату y:");

if (x == 0 || y == 0)
{
    Console.WriteLine("WRONG!");
    return;
}

string quarter = CheckGraphicArea(x, y);
Console.WriteLine(quarter + " четверть");
