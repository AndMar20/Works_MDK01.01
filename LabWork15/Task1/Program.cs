namespace Task1
{
    internal class Program
    {
        delegate int Functions(int x);

        static void Main(string[] args)
        {
            Functions functions = Square;
            Console.WriteLine(functions(5));

            functions =  Factorial;
            Console.WriteLine(functions(5));

            functions = Absolute;
            Console.WriteLine(functions(5));
        }

        public static int Square(int x) => x * x;

        public static int Factorial(int x) => (x < 0) ? -1 : (x < 2) ? 1 : x * Factorial(x - 1);

        public static int Absolute(int x) => Math.Abs(x);
    }
}
