// Задача 19 
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int CountDigits(int inmputNumber)
{
    int countDigit = 0;
    
    for (; inmputNumber > 0; countDigit++)
    // 4321 
        inmputNumber /= 10;
    // 4321 0, 432,1 1, 43,21 2, 4,321 3, 0,4321 4

    return countDigit;
    //4
}

bool Palindrome(int inputNumber, int countNumbers)
{
    for (;countNumbers > 0;)
    {
        // 4321 
        int degreeOfTen = (int)(Math.Pow(10, countNumbers - 1));
        //1000
        int fistDigit = inputNumber / degreeOfTen;
        // 4321 / 1000 = 4
        int lastDigit = inputNumber % 10;
        // 4321 % 10 = 1
        
        if (fistDigit != lastDigit)
            return false;    

        inputNumber -= fistDigit * degreeOfTen;
        // inmput = 4321 - ( 4 * 1000)
        // 4321 - 4000 = 321
        inputNumber /= 10;
        // inputNumber = 321 / 10
        //32
        countNumbers -= 2;
        //2

    }

    return true;
}






