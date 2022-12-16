Console.WriteLine("Enter day of the week:");

int day = Convert.ToInt32(Console.ReadLine());

if (day == 1) 
{
     Console.WriteLine("It is Monday");
}

else if (day == 2) 
{
     Console.WriteLine("It is Tuesday");
}

else if (day == 3) 
{
     Console.WriteLine("It is Wednesday");
}

else if (day == 4) 
{
     Console.WriteLine("It is Thursday");
}

else if (day == 5) 
{
     Console.WriteLine("It is Friday");
}

else if (day == 6) 
{
     Console.WriteLine("It is Saturday");
}

else if (day == 7) 
{
     Console.WriteLine("It is Sunday");
}

else
{
    Console.WriteLine("Day must be from 1 to 7");
}