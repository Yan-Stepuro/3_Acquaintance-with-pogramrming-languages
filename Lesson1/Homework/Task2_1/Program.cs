// вопрос, почему не работает вариант с доп. переменными max и min
Console.WriteLine("Enter number 1:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number 2:");
int number2 = Convert.ToInt32(Console.ReadLine());

int max = number1;
int min = number2;

if(number1 > max) 
{
    max = number1;
    min = number2;
}
else
{
    max = number2;
    min = number1;
}

Console.WriteLine("max = " + max);
Console.WriteLine("min = " + min);

