int Factorial(int n) 
{
    if (n == 1)
        return 1;
    
    return n * Factorial(--n); 
}

int n = 10;

Console.WriteLine(Factorial(n));
