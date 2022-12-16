Console.WriteLine("Enter day of the week:");

int day = Convert.ToInt32(Console.ReadLine());

switch (day)
{
    case 1:
        Console.WriteLine("It is Monday");
        break;
    case 2:
        Console.WriteLine("It is Tuesday");
        break;
    case 3:
        Console.WriteLine("It is Wednesday");
        break;
    case 4:
        Console.WriteLine("It is Thirsday");
        break;
    case 5:
        Console.WriteLine("It is Friday");
        break;
    case 6:
        Console.WriteLine("It is Saturday");
        break;
    case 7:
        Console.WriteLine("It is Sunday");
        break;
    default:
        Console.WriteLine("Day must be from 1 to 7");
        break;
}
