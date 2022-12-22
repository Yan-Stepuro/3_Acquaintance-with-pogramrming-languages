System.Console.WriteLine("Enter 3 digit number:");

int number = Convert.ToInt32(Console.ReadLine());

if(number < 100 || number > 999)
{
    System.Console.WriteLine("Incorrect number");
}
else
{
    number = number / 10 % 10;
}

System.Console.WriteLine(number);
