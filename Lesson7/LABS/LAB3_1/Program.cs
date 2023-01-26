// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

// + вычисление на доп. диагонали



void FillArray(int[ , ] array)
{
    Random rand = new Random();
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(1, 10);
        }
    }
}

void PrintArray(int[ , ] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(string.Format("{0, 5}", array[i, j]));
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SumElementsOnMainDiagonal(int[,] array)
{
    int sum = 0;

    for(int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
    {
        sum += array[i, i];
    }
    System.Console.WriteLine("Сумма элементов главной диагонали = " + sum + '\n');
}

void SumElementsOnAdditionalDiagonal(int[ , ] array)
{    
    int sum = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {  
        for (int j = array.GetLength(1) - 1; j >= 0; j--)
        {
            if(i + j == array.GetLength(1) - 1)
            {
                 sum += array[i, j];
            }
        }
    }
    Console.WriteLine("Сумма элементов дополнительной диагонали = " + sum + "\n");
}
int[ , ] array = new int[5, 8];

FillArray(array);
PrintArray(array);
SumElementsOnMainDiagonal(array);
SumElementsOnAdditionalDiagonal(array);