// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void AvgColumns(int[,] array)
{
    for(int i = 0; i < array.GetLength(1); i++)
    {
        double summ = 0;
        double avg = 0;

        for(int j = 0; j < array.GetLength(0); j++)
        {
            summ += array[j, i];
            avg = Math.Round(summ / array.GetLength(0), 2);
        }
        Console.Write(String.Format("{0, 5}", avg));
    }
}


int rows = InputRows("Введите количество строк массива: ");
int columns = InputColumns("Введите количество столбцов массива: ");

int[,] array = FillArray(rows, columns);

PrintArray(array);

Console.WriteLine("Среднее арифметическое каждого столбца: ");
AvgColumns(array);