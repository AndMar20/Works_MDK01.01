namespace ConsoleApp1
{
    public static class Functions
    {
        public static long GetFactorial(int n)
        {
            return (n == 0) ?  1 : ((n < 0) ? 0 : (n * GetFactorial(n - 1)));
        }

        public static double GetPower(double x, int n)
        {
            return (n == 0) ? 1 : (n < 0) ? (1 / GetPower(x, -n)) : x * GetPower(x, n - 1);
        }

        public static double FastGetPower(double x, int n)
        {
            return (n == 0) ? 1 : (n < 0) ? -1 : x * FastGetPower(x , n-1);
        }
    }
}
