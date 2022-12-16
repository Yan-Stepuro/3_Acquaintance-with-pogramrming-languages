Console.WriteLine("Enter number 1:");

int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number 2:");

int number2 = Convert.ToInt32(Console.ReadLine());

int sqrMath2 = Convert.ToInt32(Math.Pow(number2, 2));

if (sqrMath2 == number1)
{
    Console.Write(number1);

    Console.Write(" is sqr of ");

    Console.WriteLine(number2);
}
else 
{
    Console.Write(number1);

    Console.Write(" is not sqr of ");
    
    Console.WriteLine(number2);
}
