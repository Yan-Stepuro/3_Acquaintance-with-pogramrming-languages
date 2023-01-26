// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int InputSize(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] CreateArray(int size)
{
    int[] array = new int[size];
    return array;
}

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArray(int[] array)
{
    System.Console.Write(string.Join(", ", array) + "\n");
}

int CountPositiveNumbers(int[] array)
{
    int count = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            count += 1;
        }
    }
    return count;
}


int size = InputSize("Введите размер массива: ");

int[] array = CreateArray(size);

FillArray(array);

PrintArray(array);

int countPositiveNumbers = CountPositiveNumbers(array);

System.Console.WriteLine("Количество положительных чисел: " + countPositiveNumbers);
