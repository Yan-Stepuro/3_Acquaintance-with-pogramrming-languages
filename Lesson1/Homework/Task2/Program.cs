//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Enter number 1:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number 2:");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine("max = " + number1);
    Console.WriteLine("min = " + number2);
}
else 
{
    Console.WriteLine("max = " + number2);
    Console.WriteLine("min = " + number1);
}

// вопрос, почему не работает вариант с доп. переменными max и min
//Console.WriteLine("Enter number 1:");
//int number1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter number 2:");
//int number2 = Convert.ToInt32(Console.ReadLine());

// int max = number1;
// int min = number2;

//if (number1 > number2)
//{
    //int max = number1;
    //int min = number2;
//}
//else 
//{
    //int max = number2;
    //int min = number1;
//}
//Console.WriteLine("max = " + max);
//Console.WriteLine("min = " + min);