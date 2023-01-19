// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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
    return String.Join(",", array);
}

void PrintArray(int[] array)
{
    System.Console.WriteLine(GetArrayInString(array));
}

string MultiplyNumbers(int[] array)
{
    string result = String.Empty;

    for(int i = 0; i < array.Length / 2; i++)
    {
        result += (array[i] * array[array.Length - 1 - i]) + " ";
    }

    if(array.Length % 2 == 1)
    {
        result += array[array.Length / 2];
    }

    return result;
}


int size = 5;
int[] array = CreateArray(size);
FillArrayRandomNumbers(array);
GetArrayInString(array);
PrintArray(array);

System.Console.WriteLine(MultiplyNumbers(array));
