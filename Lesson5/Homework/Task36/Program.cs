// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
        array[i] = rnd.Next(0, 100);
    }
}

int SummOdds(int[] array)
{
    int summ = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0)
        {
            summ += array[i];
        }
    }
    return summ;
}

int size = InputSize("Введите размер массива: ");
int[] array = new int[size];

FillArray(array);
System.Console.WriteLine(String.Join(", ", array));

int summOdds = SummOdds(array);
System.Console.WriteLine(summOdds);
