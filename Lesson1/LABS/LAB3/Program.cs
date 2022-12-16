Console.WriteLine("Enter day of the week:");

int day = Convert.ToInt32(Console.ReadLine());

if (day == 1) 
{
     Console.WriteLine("It is Monday");
}

if (day == 2) 
{
     Console.WriteLine("It is Tuesday");
}

if (day == 3) 
{
     Console.WriteLine("It is Wednesday");
}

if (day == 4) 
{
     Console.WriteLine("It is Thursday");
}

if (day == 5) 
{
     Console.WriteLine("It is Friday");
}

if (day == 6) 
{
     Console.WriteLine("It is Saturday");
}

if (day == 7) 
{
     Console.WriteLine("It is Sunday");
}

if (day > 7)
{
    Console.WriteLine("Day must be from 1 to 7");
}

if (day < 1)
{
    Console.WriteLine("Day must be from 1 to 7");
}