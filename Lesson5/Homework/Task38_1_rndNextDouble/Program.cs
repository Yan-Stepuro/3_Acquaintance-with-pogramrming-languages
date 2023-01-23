// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

//решение через rnd.NextDouble()

int InputSize(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(double[] array)
{
    Random rnd = new Random();

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round((rnd.NextDouble() * 100), 2);
    }
}

double FindMin(double[] array)
{
    double min = array[0];

    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
        }
    }

    return min;
}

double FindMax(double[] array)
{
    double max = array[0];

    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
    }

    return max;
}

double Substraction(double min, double max)
{
    double result = Math.Round((max - min), 2);
    return result;
}

int size = InputSize("Введите размер массива: ");
double[] array = new double[size];

FillArray(array);
System.Console.WriteLine(String.Join(", ", array));

double min = FindMin(array);
System.Console.WriteLine($"Минимальное значение: {min}");

double max = FindMax(array);
System.Console.WriteLine($"Максимальное значение: {max}");

double substraction = Substraction(min, max);
System.Console.WriteLine($"Разница между максимальным и минимальным: {substraction}");
