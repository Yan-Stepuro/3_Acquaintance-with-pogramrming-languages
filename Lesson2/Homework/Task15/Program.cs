// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Введите день недели");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 1 || number > 7)
{
    System.Console.WriteLine("Число должно быть от 1 до 7");
}
else 
{
    switch(number)
    {
        case 1 : 
            System.Console.WriteLine("нет");
            break;
        case 2 : 
            System.Console.WriteLine("нет");
            break;
        case 3 : 
            System.Console.WriteLine("нет");
            break;
        case 4 : 
            System.Console.WriteLine("нет");
            break;
        case 5 : 
            System.Console.WriteLine("нет");
            break;
        case 6 : 
            System.Console.WriteLine("да");
            break;
        case 7 : 
            System.Console.WriteLine("да");
            break;
    }
}