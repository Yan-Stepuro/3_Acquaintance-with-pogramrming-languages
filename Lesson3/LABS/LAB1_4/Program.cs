﻿int Summ(int a, int b) // записали функцию и ее условия (она не выполняется, просто записано. Она выполнится, когда к ней обратятся в дальнейшем)
{
    int summ = a + b;
    return summ;
}

int a = 3; // объявили переменную 
int b = 4; // объявили переменную 
int qwe = Summ(a, b); // обЪявили переменную, в которую записали результат выполнения функции, которую записали выше

Console.WriteLine(qwe);
Console.WriteLine(a);