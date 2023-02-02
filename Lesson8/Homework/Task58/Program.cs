// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] FillMatrix(int rows, int columns)
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

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(string.Format("{0, 5}", matrix[i, j]));
        }

        Console.WriteLine();
    }
}

int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] multiplyMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for(int j = 0; j < multiplyMatrix.GetLength(1); j++)
    {
        for(int i = 0; i < multiplyMatrix.GetLength(1); i++)
        {
            for(int k = 0; k < matrix1.GetLength(1); k++)
            {
                multiplyMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }

    return multiplyMatrix;
}

int rows = 2;
int columns = 2;

int[,] matrix1 = FillMatrix(2, 4);
PrintMatrix(matrix1);

System.Console.WriteLine();

int[,] matrix2 = FillMatrix(4, 2);
PrintMatrix(matrix2);

int[,] multiplyMatrix = MultiplyMatrix(matrix1, matrix2);
PrintMatrix(multiplyMatrix);

