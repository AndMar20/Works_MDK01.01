Console.WriteLine("Последовательный вызов");
await Task.Run(() => ShowPower(2, 4));
await Task.Run(() => ShowPower(3, 0));
await Task.Run(() => ShowPower(2, -3));

Console.WriteLine("Параллельный вызов");
await Task.WhenAll(
    Task.Run(() => ShowPower(2, 4)),
    Task.Run(() => ShowPower(3, 0)),
    Task.Run(() => ShowPower(2, -3)));

static void ShowPower(double a, int n)
{
    double result = 1;

    if (n > 0)
        for (int i = 0; i < n; i++)
            result *= a;
    else
        for (int i = 0; i > n; i--)
            result *= 1 / a;

    Console.WriteLine($"{a}^{n} = {result}");
}

