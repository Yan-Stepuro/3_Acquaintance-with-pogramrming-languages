// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int InputSize(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[] array)
{
    Random rnd = new Random();

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1, 10);
    }
}

int [] CopyArray (int[] array)
{
    int[] arrayCopy = new int[array.Length];

    for(int i = 0; i < array.Length; i++)
    {
        arrayCopy[i] = array[i];
    }
    return arrayCopy;
}

int size = InputSize("Введите размер массива: ");

int[] array = new int[size];

FillArray(array);
System.Console.WriteLine(String.Join(", ", array));

int[] arrayCopy = CopyArray(array);
System.Console.WriteLine(String.Join(", ", arrayCopy));
