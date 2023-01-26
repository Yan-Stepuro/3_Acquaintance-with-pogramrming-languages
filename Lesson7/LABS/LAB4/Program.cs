
// Дан двумерный массив. Поменять местами:
// а) элементы, расположенные в правом верхнем и левом нижнем углах;
// б) элементы, расположенные в правом нижнем и левом верхнем углах.


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

void MoveElements (int[,] array)
{
    int leftUpElement = array[0, 0];
    int rightDownElement = array[array.GetLength(0) - 1, array.GetLength(1) - 1];

    int leftDownElement = array[array.GetLength(0) - 1, 0];
    int rightUpElement = array[0, array.GetLength(1) - 1];

    array[0, 0] = rightDownElement;
    array[array.GetLength(0) - 1, array.GetLength(1) - 1] = leftUpElement;

    array[array.GetLength(0) - 1, 0] = rightUpElement;
    array[0, array.GetLength(1) -1 ] = leftDownElement;

    PrintArray(array);
}

int[,] array = new int[5, 5];
FillArray(array);
PrintArray(array);

MoveElements(array);
