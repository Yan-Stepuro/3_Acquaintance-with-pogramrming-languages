Console.WriteLine("Enter the namber to display multiplication table:");

int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Таблица умножения на " + number + ":");

for (int i = 1; i < 11; i++)
{
    int result = i * number;
    Console.Write(number + " * " + i + " = "); 
    Console.WriteLine(result);
}
