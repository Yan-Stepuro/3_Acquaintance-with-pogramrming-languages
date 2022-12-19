Console.WriteLine("Enter number 1:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number 2:");
int number2 = Convert.ToInt32(Console.ReadLine());

int max = Math.Max(number1, number2);
int min = Math.Min(number1, number2);

Console.WriteLine("max = " + max);
Console.WriteLine("min = " + min);