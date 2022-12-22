//5) дано натуральное n. вычислить: 1 + 1/2 + 1/3 + 1/4 + ... + 1/n.

int n = 5;
double result = 0;

for (double i = 1; i <= n; i = i + 1)
{
    result = result + 1 / i;
}

Console.WriteLine(result);