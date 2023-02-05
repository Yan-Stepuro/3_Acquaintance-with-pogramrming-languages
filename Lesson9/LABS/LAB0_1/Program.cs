int Fibonacci (int n)
{
    if(n <= 1)
        return 1;
    
    return Fibonacci(n - 2) + Fibonacci(n - 1);
}

int n = 7;

Console.WriteLine(Fibonacci(n));

//0 1 1 2 3 5 8 = 20

