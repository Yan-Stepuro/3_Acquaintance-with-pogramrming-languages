// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

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
        array[i] = rnd.Next(50);
    }
}

string GetArrayInString(int[] array)
{
    return String.Join(",", array);
}

void PrintArray(int[] array)
{
    System.Console.WriteLine(GetArrayInString(array));
}

int CountNumbers(int[] array, int min, int max)
{
    int count = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] >= min && array[i] <= max)
            count++;
    }

    return count;
}

int size = 123;
int min = 10;
int max = 99;
int[] array = CreateArray(size);
FillArrayRandomNumbers(array);
GetArrayInString(array);
PrintArray(array);
System.Console.WriteLine(CountNumbers(array, min, max));
