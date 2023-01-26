// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

int InputRows(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int InputColumns(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FillArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];

    Random rnd = new Random();

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToInt32(rnd.Next(0, 21));
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(string.Format("{0, 5}", array[i, j]));
        }

        Console.WriteLine();
    }
}

int ReadRowFromConsole(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int ReadColumnFromConsole(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FindValue(int[,] array, int rowPosition, int columnPosition)
{
    if(rowPosition > array.GetLength(0) - 1 || columnPosition > array.GetLength(1) - 1)
    {
        Console.WriteLine($"[{rowPosition}, {columnPosition}] такого числа в массиве нет");
    }
    else
    {
        Console.WriteLine($"Число в массиве на позиции [{rowPosition}, {columnPosition}]: {array[rowPosition, columnPosition]}");
    }
}

int rows = InputRows("Введите количество строк массива: ");
int columns = InputColumns("Введите количество столбцов массива: ");

int[,] array = FillArray(rows, columns);

int rowPosition = ReadRowFromConsole("Введите номер строки: ");
int columnPosition = ReadColumnFromConsole("Введите номер столбца: ");

PrintArray(array);

FindValue(array, rowPosition, columnPosition);

