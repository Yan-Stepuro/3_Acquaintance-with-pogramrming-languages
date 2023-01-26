// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
        }
    }
}

double RewriteArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; i < array.GetLength(1); j++)
        {
            if(array[i] % 2 == 0 || array[j] == 0)
            {
                array[i, j] = Math.Pow(array[i, j], 2);
            }
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(string.Format("{0, 5}", array[i, j]));
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}



int rows = 3;
int columns = 4;

int[,] array = new int[rows, columns];

FillArray(array);
PrintArray(array);
RewriteArray(array);
PrintArray(array);