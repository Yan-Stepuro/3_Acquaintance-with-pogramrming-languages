//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти:");
int quarter  = Convert.ToInt32(Console.ReadLine());

if (quarter < 1 || quarter > 4)
{
    Console.WriteLine("Четверть на то и четверть, что числа должны быть от 1 до 4!!!!!!!!!!!!!");
    return;
}

if (quarter == 1) System.Console.WriteLine("x от 0 до плюс бесконечности \ny от 0 до плюс бесконечности"); 
if (quarter == 2) System.Console.WriteLine("x от 0 до минус бесконечности \ny от 0 до плюс бесконечности"); 
if (quarter == 3) System.Console.WriteLine("x от 0 до минус бесконечности \ny от 0 до минус бесконечности"); 
if (quarter == 4) System.Console.WriteLine("x от 0 до плюс бесконечности \ny от 0 до минус бесконечности"); 