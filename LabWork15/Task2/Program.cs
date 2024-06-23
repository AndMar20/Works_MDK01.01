namespace Task2
{
    internal class Program
    {
        public delegate void Function(int a, int b);

        static void Main(string[] args)
        {
            int a = 10;
            int b = 5;

            Function function = new Function(Sum);
            function += Difference;
            function += Product;
            function += Quotient;
            function?.Invoke(a, b);
        }

        public static void Sum(int a, int b) => Console.WriteLine($"Сумма: {a + b}");

        public static void Difference(int a, int b) => Console.WriteLine($"Разность: {a - b}");

        public static void Product(int a, int b) => Console.WriteLine($"Произведение: {a * b}");

        public static void Quotient(int a, int b) => Console.WriteLine($"Частное: {a / b}");
    }
}
