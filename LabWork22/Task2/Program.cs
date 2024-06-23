Console.WriteLine("Параллельный вызов");
await Task.WhenAll(
    Task.Run(() => Console.WriteLine($" 2^4 = {GetPower(2, 4)}")),
    Task.Run(() => Console.WriteLine($" 3^0 = {GetPower(3, 0)}")),
    Task.Run(() => Console.WriteLine($" 2^-3 = {GetPower(2, -3)}")));

var result = await Task.Run(() => GetFormulaAsync(2, 2, 2, 3, 2, 4, 2, 5));
Console.WriteLine(result);

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

async Task<double> GetFormulaAsync(double a1, int x1, double a2, int x2, double a3, int x3, double a4, int x4)
{
    return (await Task.Run(() => GetPower(a1, x1)) + await Task.Run(() => GetPower(a2, x2))) /
           (await Task.Run(() => GetPower(a3, x3)) - await Task.Run(() => GetPower(a4, x4)));
}