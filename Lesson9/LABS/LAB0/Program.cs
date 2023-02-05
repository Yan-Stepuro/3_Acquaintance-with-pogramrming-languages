void Fibonacci (int i, int j, int n)
{
    if(j >= n)
        return;
    
    if(i == 0)
        Console.Write(i + " ");

    Console.Write(j+ " ");
    Fibonacci(j, i + j, n);
}

int n = 100;
int i = 0;
int j = 1;

Fibonacci(i, j, n);

//0 1 1 2 3 5 8 13
