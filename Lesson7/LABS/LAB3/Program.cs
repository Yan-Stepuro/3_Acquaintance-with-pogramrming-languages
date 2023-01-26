// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

void FillArray(int[,] array)
{

}

void PrintArray(int[,] array)


void SumElementsOnMainDiagonal(int[,] array)
{
    int sum = 0;

    for(int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
    {
        sum += array[i, i];
    }
    System.Console.WriteLine("Сумма элементов главной диагонали = " + SumElementsOnMainDiagonal + '\n');
}


int[,] array = new int[5, 5];
FillArray(array);
PrintArray(array);
SumElementsOnMainDiagonal(array);
