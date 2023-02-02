// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

int SummElementsInRow(int[,] array, int row)
{   
    int summ = 0;
    
    for(int i = 0; i < array.GetLength(1); i++)
    {
        summ += array[row, i];
    }
    return summ;
}

int[] FillSummArray(int[,] array, int row)
{
    int[] summArray = new int[5];

    for(int i = 0; i < 5; i++)
    {
        summArray[i] = SummElementsInRow(array, i);
    }

    return summArray;
}

void PrintSummArray(int[] summArray)
{
        Console.Write($"Сумммы элементов по строкам: {string.Join(", ", summArray)}");
}

void FindMinSummRow(int[] summArray)
{
    int min = summArray[0];
    int minRow = 0;

    for(int i = 0; i < summArray.Length; i++)
    {   
        if(summArray[i] < min)
        {
            min = summArray[i];
            minRow = i;
        }
    }
    
    System.Console.WriteLine($"Наименьшая сумма элементов: {min}");
    System.Console.WriteLine($"Строка с наименьшей суммой элементов: {minRow}");
}

int rows = 5;
int columns = 4;

int[,] array = FillArray(rows, columns);
PrintArray(array);

int[] summArray = FillSummArray(array, 0);
PrintSummArray(summArray);

System.Console.WriteLine();

FindMinSummRow(summArray);