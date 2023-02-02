// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void SortArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for(int k = j + 1; k < array.GetLength(1); k++)
            {
                if(array[i, k] < array[i, j])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
            } 
        }
    }
}

int rows = InputRows("Введите количество строк массива: ");
int columns = InputColumns("Введите количество столбцов массива: ");

int[,] array = FillArray(rows, columns);

PrintArray(array);

SortArray(array);
System.Console.WriteLine();

PrintArray(array);
