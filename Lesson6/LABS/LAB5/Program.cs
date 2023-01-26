// Дан массив размера N. Найти номер его первого локального минимума (меньше любого из своих соседей)

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

int LocalMin (int[] array)
{
    for(int i = 1; i < array.Length - 1; i++)
    {
        if(array[i] < array[i - 1] && array[i] > array[i + 1])
        {
            return i;
        }
    }
    return -1;
}

int size = InputSize("Введите размер массива: ");
int[] array = new int[size];

FillArray(array);
System.Console.WriteLine(String.Join(", ", array));

int localMin = LocalMin(array);
System.Console.WriteLine(array[LocalMin(array)]);