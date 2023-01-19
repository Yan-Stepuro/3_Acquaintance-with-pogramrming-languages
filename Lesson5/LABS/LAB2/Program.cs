// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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

int[] ReverseNumbers(int[] array)
{
    int[] reversedArray = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        reversedArray[i] = array[i] * -1;
    }
    return reversedArray;
}

int size = 4;
//int[] array = CreateArray(size);
int[] array = new int[size];
FillArrayRandomNumbers(array);
GetArrayInString(array);
PrintArray(array);

int[] reversedArray = ReverseNumbers(array);
GetArrayInString(reversedArray);
PrintArray(reversedArray);

