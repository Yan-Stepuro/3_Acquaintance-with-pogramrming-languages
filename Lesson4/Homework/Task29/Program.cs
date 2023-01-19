// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] CreateArray(int size)
{
    int[] createdArray = new int[size];
    return createdArray;
}

void FillArrayRandomNumbers(int[] array)
{
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(10);
    }
}

string GetArrayInString(int[] array)
{
    return String.Join(", ", array);
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + GetArrayInString(array) + "]");
}

int size = 8;
int[] array = CreateArray(size);
FillArrayRandomNumbers(array);
GetArrayInString(array);
PrintArray(array);
