Console.WriteLine("Enter three-digit number:");

int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 & number < 1000 | number > -1000 & number < -99)
{
    Console.WriteLine(Math.Abs(number % 10));
}
else 
{
    Console.WriteLine("Invalid number");
}
