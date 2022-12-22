void Summ(int a, int b) // записали функцию
{
    a = a + b;
}

int a = 3; // объявили переменную 
int b = 4; // объявили переменную 
Summ(a, b); // выполнили функцию, которую записали выше

Console.WriteLine(Summ);
Console.WriteLine(a);

void Summ(int a, int b) // записали функцию
{
    int summ = a + b;
    return summ;
}

int a = 3; // объявили переменную 
int b = 4; // объявили переменную 
int qwe = Summ(a, b); // выполнили функцию, которую записали выше

Console.WriteLine(summ);
Console.WriteLine(a);