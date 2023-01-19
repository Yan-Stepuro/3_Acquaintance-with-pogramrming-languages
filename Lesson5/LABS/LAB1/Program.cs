// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

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
        array[i] = rnd.Next(-9, 10);
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

int SummPositiveNumbers(int[] array)
{
    int summ = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) summ += array[i];
    }

    return summ;
}

int SummNegativeNumbers(int[] array)
{
    int summ = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) summ += array[i];
    }

    return summ;
}

int size = 12;

int[] array = CreateArray(size);

FillArrayRandomNumbers(array);

PrintArray(array);

int summPositiveNumbers = SummPositiveNumbers(array);
System.Console.WriteLine(summPositiveNumbers);

int summNegativeNumbers = SummNegativeNumbers(array);
System.Console.WriteLine(summNegativeNumbers);





