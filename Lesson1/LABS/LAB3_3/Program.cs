Console.WriteLine("Enter day of the week:");

int day = Convert.ToInt32(Console.ReadLine());

if ((day < 1) || (day > 7)) Console.Write("Day must be from 1 to 7");
if (day == 1) Console.Write("Monday");
if (day == 2) Console.Write("Tuesday");
if (day == 3) Console.Write("Wednesday");
if (day == 4) Console.Write("Thirsday");
if (day == 5) Console.Write("Friday");
if (day == 6) Console.Write("Saturday");
if (day == 7) Console.Write("Sunday");