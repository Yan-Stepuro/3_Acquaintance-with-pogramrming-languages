// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// Пример. Есть набор данных:
// { 1, 9, 9, 0, 2, 8, 0, 9 }


// Частотный массив можно представить так:
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза


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

int[] FillAray2 (int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int[] array2 = new int[rows * columns];

    for(int i = 0; i < array2.Length; i++)
    {
        array2[i] = array[i / columns, i % columns];
    }

    return array2;
}

void SortArray2(int[] array2)
{
    for(int i = 0; i < array2.Length - 1; i++)
    {
        for(int j = i + 1; j < array2.Length; j++)
        {
            if(array2[j] < array2[i])
            {
                int temp = array2[i];
                array2[i] = array2[j];
                array2[j] = temp;
            }
        }
    }
}

void CountElements(int[] array2)
{
    int count = 1;

    for(int i = 0; i < array2.Length; i++)
    {   
        if(i == array2.Length - 1)
        {
            Console.WriteLine($"{array2[i]} встречается {count} раз");
            break;
        }

        if(array2[i] == array2[i + 1])
        {
            count++;
        }
        else
        {
            Console.WriteLine($"{array2[i]} встречается {count} раз");
            count = 1;
        }
    }
}

int rows = InputRows("Введите количество строк массива: ");
int columns = InputColumns("Введите количество столбцов массива: ");

int[,] array = FillArray(rows, columns);

PrintArray(array);

int[] array2 = FillAray2(array);
System.Console.WriteLine(String.Join(", ", array2));

SortArray2(array2);
System.Console.WriteLine(String.Join(", ", array2));

CountElements(array2);







