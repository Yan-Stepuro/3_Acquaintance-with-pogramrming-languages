Console.WriteLine("Enter the number:");

int number = Convert.ToInt32(Console.ReadLine());
int min = -1 * number;

if (number > 0)
{
    Console.Write("Numbers from ");
    Console.Write (min);
    Console.Write(" to ");
    Console.Write(number);
    Console.WriteLine(":");

    for (int i = min; i < number; i++)
    {
        Console.Write(i + ", ");
    }

    Console.WriteLine(number);
}
else 
{
   Console.Write("Введите положительное число"); 
}
