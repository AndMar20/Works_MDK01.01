double number = 2;
int power = 0;

double GetPower(double a, int n)
{
    double result = 1;
    if (n > 0)
    {
        for (int i = 0; i < n; i++)
            result *= a;
        return result;
    }
    for (int i = 0; i > n; i--)
        result *= a;
    return 1 / result;
}

Console.WriteLine($"{number}^{power} = {GetPower(number, power)}");