//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4

int Qwe(string name)
{
    Console.WriteLine(name);
    int Ax  = Convert.ToInt32(Console.ReadLine());
    return Ax;
}

int Ax = Qwe("Введите число: ");
string answer = "";

for (int i = 1; i <= Ax; i++)
{
    if (i == Ax)
    {
        answer = answer + Math.Pow(i, 2).ToString();
    }
    else 
    {
        answer = answer + Math.Pow(i, 2).ToString() + ", ";
    }
}

Console.WriteLine(answer);



