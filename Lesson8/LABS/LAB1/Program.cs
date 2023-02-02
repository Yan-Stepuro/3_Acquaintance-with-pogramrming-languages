// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 8 4 2 4
// 5 9 2 3
// 1 4 7 2


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
            array[i, j] = Convert.ToInt32(rnd.Next(0, 11));
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

void SwapRows(int[,] array)
{
    for(int i = 0; i < array.GetLength(1); i++)
    {
        int temp = array[0, i];
        array[0, i] = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0) - 1, i] = temp;
    }
}

int rows = InputRows("Введите количество строк массива: ");
int columns = InputColumns("Введите количество столбцов массива: ");

int[,] array = FillArray(rows, columns);

PrintArray(array);
SwapRows(array);
System.Console.WriteLine();
PrintArray(array);