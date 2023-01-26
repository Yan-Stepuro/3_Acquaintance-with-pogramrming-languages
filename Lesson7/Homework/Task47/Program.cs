// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int InputRows(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int InputColumns(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

double[,] CreateArray(int rows, int columns)
{
    double[,] array = new double[rows, columns];
    return array;
}

double[,] FillArray(double[,] array)
{
    Random rnd = new Random();

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round((rnd.NextDouble() * 100), 2);
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(string.Format("{0, 7}", array[i, j]));
        }
        Console.WriteLine();
    }
}

int rows = InputRows("Введите количество строк: ");
int columns = InputColumns("Введите количество столбцов: ");
double[,] array = CreateArray(rows, columns);
double[,] result = FillArray(array);
PrintArray(array);


