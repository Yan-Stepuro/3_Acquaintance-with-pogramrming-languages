// Задача 63. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N. 
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"


void FindNumber(int currIndex, int n)
{
    if(currIndex == n)
        return;
    
    System.Console.WriteLine(currIndex);
    FindNumber(++currIndex, n); // или currIndex += 1 или currIndex + 1 
}

int n = 10;

FindNumber(1, n);
