// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
// https://ru.wikihow.com/%D0%BF%D0%B5%D1%80%D0%B5%D0%B2%D0%BE%D0%B4%D0%B8%D1%82%D1%8C-%D0%B8%D0%B7-%D0%B4%D0%B5%D1%81%D1%8F%D1%82%D0%B8%D1%87%D0%BD%D0%BE%D0%B9-%D1%81%D0%B8%D1%81%D1%82%D0%B5%D0%BC%D1%8B-%D1%81%D1%87%D0%B8%D1%81%D0%BB%D0%B5%D0%BD%D0%B8%D1%8F-%D0%B2-%D0%B4%D0%B2%D0%BE%D0%B8%D1%87%D0%BD%D1%83%D1%8E


string NewNumber(int num)
{
    string binary = String.Empty;

    for(; num > 0; num /= 2)
    {
        binary += num % 2;
    }
    return binary;
}

string FlipOver(string binary)
{
    string result = string.Empty;

    for(int i = binary.Length - 1; i >= 0; i--)
    {
        result += binary[i];
    }
    return result;
}

System.Console.WriteLine("Введите десятичное число: ");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(NewNumber(num));
System.Console.WriteLine(FlipOver(binary));
