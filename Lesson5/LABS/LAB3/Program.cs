// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int[] CreateArray()
{
    int[] createdArray = new int[5] { 6, 7, 19, 345, 3 };
    return createdArray;
}

string GetArrayInString(int[] array)
{
    return String.Join(",", array);
}

void PrintArray(int[] array)
{
    System.Console.WriteLine(GetArrayInString(array));
}

int ReadNumberFromConsole()
{
    System.Console.WriteLine("Введите число:");
    int NumberFromConsole = Convert.ToInt32(Console.ReadLine());
    return NumberFromConsole;
}

string CompareNumbers(int numberFromConsole, int[] array)
{
    string result = String.Empty;

    for(int i = 0; i < array.Length; i++)
    {
        if(numberFromConsole == array[i])
        {
            result = "Да";
            return result;
        }
        else
        {
            result = "Нет";
        }
    }
    return result;
}

int[] array = CreateArray();
int numberFromConsole = ReadNumberFromConsole();

GetArrayInString(array);
PrintArray(array);
System.Console.WriteLine(CompareNumbers(numberFromConsole, array));




